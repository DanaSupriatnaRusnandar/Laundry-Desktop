using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Luthor.lib;

namespace Laundry
{
    public partial class UserControlPengeluaran : UserControl
    {
        string getIdPengeluaran;
        int Total;
        public UserControlPengeluaran()
        {
            InitializeComponent();
        }

        private void UserControlPengeluaran_Load(object sender, EventArgs e)
        {
            dataGridViewPengeluaran.BorderStyle = BorderStyle.None;
            dataGridViewPengeluaran.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewPengeluaran.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewPengeluaran.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewPengeluaran.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewPengeluaran.BackgroundColor = Color.White;

            dataGridViewPengeluaran.EnableHeadersVisualStyles = false;
            dataGridViewPengeluaran.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewPengeluaran.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewPengeluaran.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            Tampilkan();
        }

        private void Tampilkan()
        {
            if (Session.getUserLogged().Rows[0].Field<string>("role") == "admin")
            {
                DataTable data = Db.Read($"SELECT * FROM tb_pengeluaran join tb_outlet on tb_pengeluaran.id_outlet = tb_outlet.id ORDER BY tb_pengeluaran.id DESC");
                dataGridViewPengeluaran.AutoGenerateColumns = false;
                dataGridViewPengeluaran.DataSource = data;
            }
            else if (Session.getUserLogged().Rows[0].Field<string>("role") != "admin")
            {
                DataTable data = Db.Read($"SELECT * FROM tb_pengeluaran join tb_outlet on tb_pengeluaran.id_outlet = tb_outlet.id WHERE tb_pengeluaran.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")} ORDER BY tb_pengeluaran.id DESC");
                dataGridViewPengeluaran.AutoGenerateColumns = false;
                dataGridViewPengeluaran.DataSource = data;
            }
            hitungPengeluaran();

        }

        private void CariData(string keyword)
        {
            if(Session.getUserLogged().Rows[0].Field<string>("role") == "admin")
            {
                dataGridViewPengeluaran.AutoGenerateColumns = false;
                dataGridViewPengeluaran.DataSource = Db.Read($"SELECT * FROM tb_pengeluaran join tb_outlet on tb_pengeluaran.id_outlet = tb_outlet.id WHERE CONCAT (tb_outlet.nama_outlet, tb_pengeluaran.nama_barang, tb_pengeluaran.tgl, tb_pengeluaran.total, tb_pengeluaran.keterangan) LIKE '%{keyword}%'");
            }
            else if (Session.getUserLogged().Rows[0].Field<string>("role") != "admin")
            {
                dataGridViewPengeluaran.AutoGenerateColumns = false;
                dataGridViewPengeluaran.DataSource = Db.Read($"SELECT * FROM tb_pengeluaran join tb_outlet on tb_pengeluaran.id_outlet = tb_outlet.id WHERE tb_pengeluaran.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")} AND concat(tb_pengeluaran.nama_barang, tb_pengeluaran.tgl, tb_pengeluaran.total, tb_pengeluaran.keterangan) LIKE '%{keyword}%' ");
            }
            hitungPengeluaran();
        }

        private void hitungPengeluaran()
        {
            //Jumlah pengeluaran
            double pengeluaran = 0;
            foreach (DataGridViewRow row in dataGridViewPengeluaran.Rows)
            {
                pengeluaran = pengeluaran + Convert.ToDouble(row.Cells["total"].Value);
            }
            txtTotal.Text = pengeluaran.ToString("C0");
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Tampilkan();
            txtCari.Clear();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            new TambahDataPengeluaran(btn_refresh, getIdPengeluaran).ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin menghapus data pengeluarana Ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_pengeluaran", $"id = {getIdPengeluaran}");
                Tampilkan();
                MessageBox.Show("Data pengeluaran berhasil dihapus!");

            }
        }

        private void dataGridViewPengeluaran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewPengeluaran.CurrentCell.RowIndex;
            getIdPengeluaran = dataGridViewPengeluaran.Rows[row].Cells["id"].Value.ToString();
        }

        private void dataGridViewPengeluaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewPengeluaran.Columns["edit"].Index)
            {
                var row = dataGridViewPengeluaran.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                string id_outlet = row.Cells["id_outlet"].Value.ToString();
                string outlet = row.Cells["nama_outlet"].Value.ToString();
                string nama = row.Cells["nama_barang"].Value.ToString();
                DateTime tgl = (DateTime)row.Cells["tgl"].Value;
                string total = row.Cells["total"].Value.ToString();
                string keterangan = row.Cells["keterangan"].Value.ToString();
                new EditDataPengeluaran(btn_refresh, id,id_outlet, outlet, nama, tgl, total, keterangan).ShowDialog();
            }
        }

        //Cari Data
        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (txtCari.Text.Length > 0)
            CariData(txtCari.Text);
        }

        //Memunculkan Number
        private void dataGridViewPengeluaran_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var g = (DataGridView)sender;
            var r = new Rectangle(e.RowBounds.Left, e.RowBounds.Top,
                g.RowHeadersWidth, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, $"{e.RowIndex + 1}",
                g.RowHeadersDefaultCellStyle.Font, r, g.RowHeadersDefaultCellStyle.ForeColor);
        }

        private void dataGridViewPengeluaran_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
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
