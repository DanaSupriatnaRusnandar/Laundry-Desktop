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
        public UserControlTransaksi()
        {
            InitializeComponent();
        }

        public void Tampilkan()
        {
            if (Session.getUserLogged().Rows[0].Field<string>("role") == "superAdmin")
            {
                DataTable data = Db.Read($"SELECT * FROM tb_transaksi join tb_outlet on tb_transaksi.id_outlet = tb_outlet.id JOIN tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_kurir ON tb_transaksi.id_kurir = tb_kurir.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id ORDER BY tb_transaksi.id DESC");
                dataGridViewTransaksi.AutoGenerateColumns = false;
                dataGridViewTransaksi.DataSource = data;
            }
            else
            {
                DataTable data = Db.Read($"SELECT * FROM tb_transaksi join tb_outlet on tb_transaksi.id_outlet = tb_outlet.id JOIN tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_kurir ON tb_transaksi.id_kurir = tb_kurir.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id WHERE tb_transaksi.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")} ORDER BY tb_transaksi.id DESC");
                dataGridViewTransaksi.AutoGenerateColumns = false;
                dataGridViewTransaksi.DataSource = data;
            }
            Pemasukan();
        }

        private void CariData(string keyword)
        {
            //Pencarian tidak tampil
            if (Session.getUserLogged().Rows[0].Field<string>("role") == "superAdmin")
            {
                dataGridViewTransaksi.AutoGenerateColumns = false;
                dataGridViewTransaksi.DataSource = Db.Read($"SELECT * FROM tb_transaksi join tb_outlet on tb_transaksi.id_outlet = tb_outlet.id JOIN tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_kurir ON tb_transaksi.id_kurir = tb_kurir.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id WHERE CONCAT (tb_member.nama_member, tb_kurir.nama_kurir, tb_user.nama, tb_transaksi.tgl, tb_outlet.nama_outlet, tb_transaksi.kode_invoice, tb_transaksi.status, tb_transaksi.dibayar, tb_transaksi.total_pembayaran) LIKE '%{keyword}%'");
            }
            else if (Session.getUserLogged().Rows[0].Field<string>("role") != "superAdmin")
            {
                dataGridViewTransaksi.AutoGenerateColumns = false;
                dataGridViewTransaksi.DataSource = Db.Read($"SELECT * FROM tb_transaksi join tb_outlet on tb_transaksi.id_outlet = tb_outlet.id JOIN tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_kurir ON tb_transaksi.id_kurir = tb_kurir.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id WHERE tb_transaksi.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")} AND CONCAT (tb_member.nama_member, tb_kurir.nama_kurir, tb_user.nama, tb_transaksi.tgl, tb_outlet.nama_outlet, tb_transaksi.kode_invoice, tb_transaksi.status, tb_transaksi.dibayar, tb_transaksi.total_pembayaran) LIKE '%{keyword}%'");

            }
            Pemasukan();
        }

        private void Pemasukan()
        {
            //Jumlah Pemasukan
            double pemasukan = 0;
            foreach (DataGridViewRow row in dataGridViewTransaksi.Rows)
            {
                pemasukan = pemasukan + Convert.ToDouble(row.Cells["total_pembayaran"].Value);
            }
            txtTotal.Text = pemasukan.ToString("C0");
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
                string invoice = row.Cells["kode_invoice"].Value.ToString();
                new EditTransaksi(btn_refresh, invoice).ShowDialog();
            }
        }

        //Cari Data
        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (txtCari.Text.Length > 0)
                CariData(txtCari.Text);
        }
    }
}
