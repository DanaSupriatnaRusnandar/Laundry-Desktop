    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Luthor.lib;

namespace Laundry
{
    public partial class UserControlDataUser : UserControl
    {
        public UserControlDataUser()
        {
            InitializeComponent();
        }
        string getIdUser;

        private void UserControlDataAdmin_Load(object sender, EventArgs e)
        {
            dataGridViewAdmin.BorderStyle = BorderStyle.None;
            dataGridViewAdmin.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewAdmin.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewAdmin.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewAdmin.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewAdmin.BackgroundColor = Color.White;

            dataGridViewAdmin.EnableHeadersVisualStyles = false;
            dataGridViewAdmin.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewAdmin.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewAdmin.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            Tampilkan();
        }

        //Function
        private void Tampilkan()
        {
            if (Session.getUserLogged().Rows[0].Field<string>("role") == "superAdmin")
            {
                DataTable data = Db.Read($"SELECT * FROM tb_user JOIN tb_outlet ON tb_user.id_outlet = tb_outlet.id ORDER BY tb_user.id DESC");
                dataGridViewAdmin.AutoGenerateColumns = false;
                dataGridViewAdmin.DataSource = data;
            }
            else if (Session.getUserLogged().Rows[0].Field<string>("role") != "superAdmin")
            {
                DataTable data = Db.Read($"SELECT * FROM tb_user JOIN tb_outlet ON tb_user.id_outlet = tb_outlet.id WHERE tb_user.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")} ORDER BY tb_user.id DESC");
                dataGridViewAdmin.AutoGenerateColumns = false;
                dataGridViewAdmin.DataSource = data;
            }
                
        }

        private void CariData(string keyword)
        {
            if (Session.getUserLogged().Rows[0].Field<string>("role") == "superAdmin")
            {
                dataGridViewAdmin.AutoGenerateColumns = false;
                dataGridViewAdmin.DataSource = Db.Read($"SELECT * FROM tb_user JOIN tb_outlet ON tb_user.id_outlet = tb_outlet.id WHERE CONCAT(tb_user.nama, tb_user.username, tb_outlet.nama_outlet, tb_user.role) LIKE '%{keyword}%'");
            }
            else if (Session.getUserLogged().Rows[0].Field<string>("role") != "superAdmin")
            {
                dataGridViewAdmin.AutoGenerateColumns = false;
                dataGridViewAdmin.DataSource = Db.Read($"SELECT * FROM tb_user JOIN tb_outlet ON tb_user.id_outlet = tb_outlet.id WHERE tb_user.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")} AND CONCAT(tb_user.nama, tb_user.username, tb_user.role) LIKE '%{keyword}%'");
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Tampilkan();
            txtCari.Clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin menghapus data user Ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_user", $"id = {getIdUser}");
                MessageBox.Show("Data user berhasil dihapus!");
                Tampilkan();
            }
        }
        //Event Hapus
        private void dataGridViewAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewAdmin.CurrentCell.RowIndex;
            getIdUser = dataGridViewAdmin.Rows[row].Cells["id"].Value.ToString();
        }

        //Event Edit
        private void dataGridViewAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridViewAdmin.Columns["edit"].Index)
            {
                var row = dataGridViewAdmin.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                string nama = row.Cells["nama"].Value.ToString();
                string username = row.Cells["username"].Value.ToString();
                string password = row.Cells["password"].Value.ToString();
                string id_outlet = row.Cells["id_outlet"].Value.ToString();
                string outlet = row.Cells["nama_outlet"].Value.ToString();
                string role = row.Cells["role"].Value.ToString();
                new EditDataUser(btn_refresh ,id, nama, username, password, id_outlet, outlet, role).ShowDialog();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            new TambahDataUser(btn_refresh, getIdUser).ShowDialog();
        }

        //Cari Data
        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (txtCari.Text.Length > 0)
                CariData(txtCari.Text);
        }

        //Menampilkan Number
        private void dataGridViewAdmin_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var g = (DataGridView)sender;
            var r = new Rectangle(e.RowBounds.Left, e.RowBounds.Top,
                g.RowHeadersWidth, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, $"{e.RowIndex + 1}",
                g.RowHeadersDefaultCellStyle.Font, r, g.RowHeadersDefaultCellStyle.ForeColor);
        }

        private void dataGridViewAdmin_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var g = (DataGridView)sender;
            if (e.RowIndex > -1 && $"{g.Rows[e.RowIndex].HeaderCell.Value}" != $"{e.RowIndex + 1}")
            {
                g.Rows[e.RowIndex].HeaderCell.Value = $"{e.RowIndex + 1}";
            }
        }

        public class DataGridViewRowNumberColumn : DataGridViewColumn
        {
            public DataGridViewRowNumberColumn() : base()
            {
                this.CellTemplate = new DataGridViewRowNumberCell();
                this.Width = 40;
                this.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            [Browsable(false)]
            [DefaultValue(true)]
            public override bool ReadOnly
            {
                get { return true; }
                set { base.ReadOnly = true; }
            }
        }
        public class DataGridViewRowNumberCell : DataGridViewTextBoxCell
        {
            protected override void Paint(System.Drawing.Graphics graphics,
                System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds,
                int rowIndex, DataGridViewElementStates cellState, object value,
                object formattedValue, string errorText, DataGridViewCellStyle cellStyle,
                DataGridViewAdvancedBorderStyle advancedBorderStyle,
                DataGridViewPaintParts paintParts)
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value,
                    formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
            }
            protected override object GetValue(int rowIndex)
            {
                return rowIndex + 1;
            }
            protected override bool SetValue(int rowIndex, object value)
            {
                return base.SetValue(rowIndex, rowIndex + 1);
            }
        }
    }
}
