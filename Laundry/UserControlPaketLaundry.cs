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
    public partial class UserControlPaketLaundry : UserControl
    {
        string Outlet;
        public UserControlPaketLaundry()
        {
            InitializeComponent();
        }
        string getIdPaketLaundry;

        private void UserControlPaketLaundry_Load(object sender, EventArgs e)
        {
            dataGridViewpaket.BorderStyle = BorderStyle.None;
            dataGridViewpaket.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewpaket.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewpaket.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewpaket.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewpaket.BackgroundColor = Color.White;

            dataGridViewpaket.EnableHeadersVisualStyles = false;
            dataGridViewpaket.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewpaket.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewpaket.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            Tampilkan();
        }

        //Function
        private void Tampilkan()
        {
            if (Session.getUserLogged().Rows[0].Field<string>("role") == "superAdmin")
            {
                DataTable data = Db.Read($"SELECT * FROM tb_paket JOIN tb_outlet ON tb_paket.id_outlet = tb_outlet.id JOIN tb_jenis ON tb_paket.id_jenis = tb_jenis.id ORDER BY tb_paket.id DESC");
                dataGridViewpaket.AutoGenerateColumns = false;
                dataGridViewpaket.DataSource = data;
            }
            else if (Session.getUserLogged().Rows[0].Field<string>("role") != "superAdmin")
            {
                DataTable data = Db.Read($"SELECT * FROM tb_paket JOIN tb_outlet ON tb_paket.id_outlet = tb_outlet.id JOIN tb_jenis ON tb_paket.id_jenis = tb_jenis.id WHERE tb_paket.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")} ORDER BY tb_paket.id DESC");
                dataGridViewpaket.AutoGenerateColumns = false;
                dataGridViewpaket.DataSource = data;
            }
        }
        
        private void CariData(string keyword)
        {
            if (Session.getUserLogged().Rows[0].Field<string>("role") == "superAdmin")
            {
                dataGridViewpaket.AutoGenerateColumns = false;
                dataGridViewpaket.DataSource = Db.Read($"SELECT * FROM tb_paket JOIN tb_outlet ON tb_paket.id_outlet = tb_outlet.id JOIN tb_jenis ON tb_paket.id_jenis = tb_jenis.id WHERE CONCAT (tb_outlet.nama_outlet, tb_paket.nama_paket, tb_jenis.jenis, tb_jenis.harga) LIKE '%{keyword}%'");
            }
            else if (Session.getUserLogged().Rows[0].Field<string>("role") != "superAdmin")
            {
                dataGridViewpaket.AutoGenerateColumns = false;
                dataGridViewpaket.DataSource = Db.Read($"SELECT * FROM tb_paket JOIN tb_outlet ON tb_paket.id_outlet = tb_outlet.id JOIN tb_jenis ON tb_paket.id_jenis = tb_jenis.id WHERE tb_paket.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")} AND CONCAT(tb_paket.nama_paket, tb_jenis.jenis, tb_jenis.harga) LIKE '%{keyword}%'");
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Tampilkan();
            txtCari.Clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin menghapus data paket laundry Ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_paket", $"id = {getIdPaketLaundry}");
                Tampilkan();
                MessageBox.Show("Data paket laundry berhasil dihapus");
            }
        }

        //Event Hapus
        private void dataGridViewpaket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewpaket.CurrentCell.RowIndex;
            getIdPaketLaundry = dataGridViewpaket.Rows[row].Cells["id"].Value.ToString();
        }

        //Event edit
        private void dataGridViewpaket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewpaket.Columns["edit"].Index)
            {
                var row = dataGridViewpaket.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                string outlet = row.Cells["nama_outlet"].Value.ToString();
                string nama_paket = row.Cells["nama_paket"].Value.ToString();
                string id_jenis = row.Cells["id_jenis"].Value.ToString();
                string jenis = row.Cells["jenis"].Value.ToString();
                string harga = row.Cells["harga"].Value.ToString();
                new EditPaketLaundry(btn_refresh, id, outlet, nama_paket, id_jenis, jenis, harga).ShowDialog();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            new TambahPaketLaundry(this, btn_refresh, Outlet).ShowDialog();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (txtCari.Text.Length > 0)
                CariData(txtCari.Text);
        }

        //Menampilkan Number
        private void dataGridViewpaket_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var g = (DataGridView)sender;
            var r = new Rectangle(e.RowBounds.Left, e.RowBounds.Top,
                g.RowHeadersWidth, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, $"{e.RowIndex + 1}",
                g.RowHeadersDefaultCellStyle.Font, r, g.RowHeadersDefaultCellStyle.ForeColor);
        }

        private void dataGridViewpaket_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
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
