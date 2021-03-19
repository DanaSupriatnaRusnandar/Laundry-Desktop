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
    public partial class UserControlTransaksi : UserControl
    {
        string getIdTransaksi;
        int Total;
        public UserControlTransaksi()
        {
            InitializeComponent();
        }

        public void Tampilkan()
        {
            if (Session.getUserLogged().Rows[0].Field<string>("role") == "superAdmin")
            {
                DataTable data = Db.Read($"SELECT * FROM tb_transaksi join tb_outlet on tb_transaksi.id_outlet = tb_outlet.id JOIN tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_kurir ON tb_transaksi.id_kurir = tb_kurir.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id");
                dataGridViewTransaksi.AutoGenerateColumns = false;
                dataGridViewTransaksi.DataSource = data;
            }
            else
            {
                DataTable data = Db.Read($"SELECT * FROM tb_transaksi join tb_outlet on tb_transaksi.id_outlet = tb_outlet.id JOIN tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_kurir ON tb_transaksi.id_kurir = tb_kurir.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id WHERE tb_transaksi.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")}");
                dataGridViewTransaksi.AutoGenerateColumns = false;
                dataGridViewTransaksi.DataSource = data;
            }
        }

        private void CariData(string keyword)
        {
            //Pencarian tidak tampil
            if (Session.getUserLogged().Rows[0].Field<string>("role") == "superAdmin")
            {
                dataGridViewTransaksi.AutoGenerateColumns = false;
                dataGridViewTransaksi.DataSource = Db.Read($"SELECT * FROM tb_transaksi join tb_outlet on tb_transaksi.id_outlet = tb_outlet.id JOIN tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_kurir ON tb_transaksi.id_kurir = tb_kurir.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id WHERE tb_outlet.nama_outlet LIKE '%{keyword}%' OR tb_member.nama_member LIKE '%{keyword}%' OR tb_kurir.nama_kurir '%{keyword}%' OR tb_user.nama LIKE '%{keyword}%' OR tb_transaksi.tgl LIKE '%{keyword}%'");

            }
            else if (Session.getUserLogged().Rows[0].Field<string>("role") != "superAdmin")
            {
                dataGridViewTransaksi.AutoGenerateColumns = false;
                dataGridViewTransaksi.DataSource = Db.Read($"SELECT * FROM tb_transaksi join tb_outlet on tb_transaksi.id_outlet = tb_outlet.id JOIN tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_kurir ON tb_transaksi.id_kurir = tb_kurir.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id WHERE tb_transaksi.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")} AND tb_outlet.nama_outlet LIKE '%{keyword}%' OR tb_member.nama_member LIKE '%{keyword}%' OR tb_kurir.nama_kurir LIKE '%{keyword}%' OR tb_user.nama LIKE '%{keyword}%' OR tb_transaksi.tgl LIKE '%{keyword}%'");

            }
        }

        private void UserControlTransaksi_Load(object sender, EventArgs e)
        {
            dataGridViewTransaksi.BorderStyle = BorderStyle.None;
            dataGridViewTransaksi.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewTransaksi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewTransaksi.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewTransaksi.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewTransaksi.BackgroundColor = Color.White;

            dataGridViewTransaksi.EnableHeadersVisualStyles = false;
            dataGridViewTransaksi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewTransaksi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewTransaksi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            Tampilkan();

            //Jumlah Pemasukan
            double pemasukan = 0;
            foreach (DataGridViewRow row in dataGridViewTransaksi.Rows)
            {
                pemasukan = pemasukan + Convert.ToDouble(row.Cells["total_pembayaran"].Value);
            }
            txtTotal.Text = pemasukan.ToString("C0");
        }

        private void btnTambah_Click_1(object sender, EventArgs e)
        {
            new TambahTransaksi(btn_refresh, getIdTransaksi).ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Tampilkan();
            txtCari.Clear();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            CariData(txtCari.Text);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin menghapus data transaksi Ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_transaksi", $"id = {getIdTransaksi}");
                Tampilkan();
                MessageBox.Show("Data transaksi berhasil dihapus!");
            }
        }

        //Event Hapus
        private void dataGridViewTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewTransaksi.CurrentCell.RowIndex;
            getIdTransaksi = dataGridViewTransaksi.Rows[row].Cells["id"].Value.ToString();
        }

        //Event Edit
        private void dataGridViewTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewTransaksi.Columns["edit"].Index)
            {
                var row = dataGridViewTransaksi.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                string outlet = row.Cells["nama_outlet"].Value.ToString();
                string invoice = row.Cells["kode_invoice"].Value.ToString();
                string pelanggan = row.Cells["nama_member"].Value.ToString();
                DateTime tanggal = (DateTime)row.Cells["tgl"].Value;
                DateTime batas_waktu = (DateTime)row.Cells["batas_waktu"].Value;
                DateTime tgl_bayar = (DateTime)row.Cells["tgl_bayar"].Value;
                string biaya_tambahan = row.Cells["biaya_tambahan"].Value.ToString();
                string diskon = row.Cells["diskon"].Value.ToString();
                string pajak = row.Cells["pajak"].Value.ToString();
                string total = row.Cells["total_pembayaran"].Value.ToString();
                string status = row.Cells["status"].Value.ToString();
                string dibayar = row.Cells["dibayar"].Value.ToString();
                string kuris = row.Cells["nama_kurir"].Value.ToString();
                string petugas = row.Cells["nama"].Value.ToString();
                new EditTransaksi(btn_refresh, id, outlet, invoice, pelanggan, tanggal, batas_waktu, tgl_bayar, biaya_tambahan, diskon, pajak, total, status, dibayar, kuris, petugas).ShowDialog();
            }
        }
    }
}
