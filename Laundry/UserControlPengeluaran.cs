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
    public partial class UserControlPengeluaran : UserControl
    {
        string getIdPengeluaran;
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
            DataTable data = Db.Read($"SELECT * FROM tb_pengeluaran join tb_outlet on tb_pengeluaran.id_outlet = tb_outlet.id");
            dataGridViewPengeluaran.AutoGenerateColumns = false;
            dataGridViewPengeluaran.DataSource = data;
        }

        private void CariData(string keyword)
        {
            dataGridViewPengeluaran.AutoGenerateColumns = false;
            dataGridViewPengeluaran.DataSource = Db.Read($"SELECT * FROM tb_pengeluaran join tb_outlet on tb_pengeluaran.id_outlet = tb_outlet.id WHERE tb_outlet.nama_outlet LIKE '%{keyword}%' OR tb_pengeluaran.nama_barang LIKE '%{keyword}%' OR tb_pengeluaran.tgl LIKE '%{keyword}%'");
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Tampilkan();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
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
                MessageBox.Show("Data pengeluaran berhasil dihhapus berhasil dihapus!");

            }
        }

        private void dataGridViewPengeluaran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewPengeluaran.CurrentCell.RowIndex;
            getIdPengeluaran = dataGridViewPengeluaran.Rows[row].Cells["id"].Value.ToString();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            CariData(txtCari.Text);
        }

        private void dataGridViewPengeluaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewPengeluaran.Columns["edit"].Index)
            {
                var row = dataGridViewPengeluaran.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                string outlet = row.Cells["nama_outlet"].Value.ToString();
                string nama = row.Cells["nama_barang"].Value.ToString();
                string tgl = row.Cells["tgl"].Value.ToString();
                string total = row.Cells["total"].Value.ToString();
                string keterangan = row.Cells["keterangan"].Value.ToString();
                new EditDataPengeluaran(btn_refresh, id, outlet, nama, tgl, total, keterangan).ShowDialog();

            }
        }
    }
}
