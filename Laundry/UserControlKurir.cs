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
    public partial class UserControlKurir : UserControl
    {
        public UserControlKurir()
        {
            InitializeComponent();
        }
        string getIdKurir;
        string kurir;

        private void UserControlKurir_Load(object sender, EventArgs e)
        {

            dataGridViewKurir.BorderStyle = BorderStyle.None;
            dataGridViewKurir.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewKurir.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewKurir.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewKurir.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewKurir.BackgroundColor = Color.White;

            dataGridViewKurir.EnableHeadersVisualStyles = false;
            dataGridViewKurir.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewKurir.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewKurir.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            Tampilkan();
        }

        private void Tampilkan()
        {
            if (Session.getUserLogged().Rows[0].Field<string>("role") == "admin")
            {
                DataTable data = Db.Read($"SELECT * FROM tb_kurir JOIN tb_outlet on tb_kurir.id_outlet = tb_outlet.id ORDER BY tb_outlet.id DESC");
                dataGridViewKurir.AutoGenerateColumns = false;
                dataGridViewKurir.DataSource = data;
            }
            else if (Session.getUserLogged().Rows[0].Field<string>("role") != "admin")
            {
                DataTable data = Db.Read($"SELECT * FROM tb_kurir JOIN tb_outlet on tb_kurir.id_outlet = tb_outlet.id WHERE tb_kurir.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")} ORDER BY tb_outlet.id DESC");
                dataGridViewKurir.AutoGenerateColumns = false;
                dataGridViewKurir.DataSource = data;
            }
        }

        private void CariData(string keyword)
        {
            if (Session.getUserLogged().Rows[0].Field<string>("role") == "admin")
            {
                dataGridViewKurir.AutoGenerateColumns = false;
                dataGridViewKurir.DataSource = Db.Read($"SELECT * FROM tb_kurir JOIN tb_outlet on tb_kurir.id_outlet = tb_outlet.id WHERE CONCAT(tb_kurir.nama_kurir, tb_kurir.alamat, tb_kurir.tlp, tb_outlet.nama_outlet) LIKE '%{keyword}%'");
            }
            else if (Session.getUserLogged().Rows[0].Field<string>("role") != "admin")
            {
                dataGridViewKurir.AutoGenerateColumns = false;
                dataGridViewKurir.DataSource = Db.Read($"SELECT * FROM tb_kurir JOIN tb_outlet on tb_kurir.id_outlet = tb_outlet.id WHERE tb_kurir.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")} AND concat(tb_kurir.nama_kurir, tb_kurir.alamat, tb_kurir.tlp) LIKE '%{keyword}%'");
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
                Db.Delete("tb_kurir", $"id = {getIdKurir}");
                Tampilkan();
                MessageBox.Show("Data kurir berhasil dihapus");
            }
        }

        //Even Hapus
        private void dataGridViewKurir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewKurir.CurrentCell.RowIndex;
            getIdKurir = dataGridViewKurir.Rows[row].Cells["id"].Value.ToString();

        }

        //Event Edit
        private void dataGridViewKurir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewKurir.Columns["edit"].Index)
            {
                var row = dataGridViewKurir.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                string nama_kurir = row.Cells["nama_kurir"].Value.ToString();
                string alamat = row.Cells["alamat"].Value.ToString();
                string tlp = row.Cells["tlp"].Value.ToString();
                string outlet = row.Cells["nama_outlet"].Value.ToString();
                new EditDataKurir(btn_refresh, id, nama_kurir, alamat, tlp, outlet).ShowDialog();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            new TambahDataKurir(btn_refresh).ShowDialog();
        }

        //Cari Data
        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (txtCari.Text.Length > 0)
                CariData(txtCari.Text);
        }

        //Menampilkan Number
        private void dataGridViewKurir_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var g = (DataGridView)sender;
            var r = new Rectangle(e.RowBounds.Left, e.RowBounds.Top,
                g.RowHeadersWidth, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, $"{e.RowIndex + 1}",
                g.RowHeadersDefaultCellStyle.Font, r, g.RowHeadersDefaultCellStyle.ForeColor);
        }

        private void dataGridViewKurir_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
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
