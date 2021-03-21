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
    public partial class UserControlPelanggan : UserControl
    {
        public UserControlPelanggan()
        {
            InitializeComponent();
        }
        string getIdPelanggan;
        string outlet;

        private void UserControlPelanggancs_Load(object sender, EventArgs e)
        {
            dataGridViewRegistrasi.BorderStyle = BorderStyle.None;
            dataGridViewRegistrasi.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewRegistrasi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewRegistrasi.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewRegistrasi.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewRegistrasi.BackgroundColor = Color.White;

            dataGridViewRegistrasi.EnableHeadersVisualStyles = false;
            dataGridViewRegistrasi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewRegistrasi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewRegistrasi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            Tampilkan();
        }

        private void Tampilkan()
        {
            if (Session.getUserLogged().Rows[0].Field<string>("role") == "superAdmin")
            {
                dataGridViewRegistrasi.AutoGenerateColumns = false;
                DataTable data = Db.Read($"SELECT * FROM tb_member JOIN tb_outlet ON tb_member.id_outlet = tb_outlet.id ORDER BY tb_transaksi.id DESC");
                dataGridViewRegistrasi.DataSource = data;
            }
            else if (Session.getUserLogged().Rows[0].Field<string>("role") != "superAdmin")
            {
                dataGridViewRegistrasi.AutoGenerateColumns = false;
                DataTable data = Db.Read($"SELECT * FROM tb_member JOIN tb_outlet ON tb_member.id_outlet = tb_outlet.id WHERE tb_member.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")} ORDER BY tb_transaksi.id DESC");
                dataGridViewRegistrasi.DataSource = data;
            }
        }

        private void CariData(string keyword)
        {
            if (Session.getUserLogged().Rows[0].Field<string>("role") == "superAdmin")
            {
                dataGridViewRegistrasi.AutoGenerateColumns = false;
                dataGridViewRegistrasi.DataSource = Db.Read($"SELECT * FROM tb_member JOIN tb_outlet ON tb_member.id_outlet = tb_outlet.id WHERE tb_member.nama_member LIKE '%{keyword}%' OR tb_member.alamat LIKE '%{keyword}%' OR tb_outlet.nama_outlet LIKE '%{keyword}%'");
            }
            else if (Session.getUserLogged().Rows[0].Field<string>("role") != "superAdmin")
            {
                dataGridViewRegistrasi.AutoGenerateColumns = false;
                dataGridViewRegistrasi.DataSource = Db.Read($"SELECT * FROM tb_member JOIN tb_outlet ON tb_member.id_outlet = tb_outlet.id WHERE tb_member.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")} AND concat(tb_member.nama_member, tb_member.alamat) LIKE '%{keyword}%'");
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Tampilkan();
            txtCari.Clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin menghapus data pelanggan Ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_member", $"id = {getIdPelanggan}");
                Tampilkan();
                MessageBox.Show("Data user berhasil dihapus!");
            }
        }

        private void dataGridViewRegistrasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewRegistrasi.CurrentCell.RowIndex;
            getIdPelanggan = dataGridViewRegistrasi.Rows[row].Cells["id"].Value.ToString();
        }

        private void dataGridViewRegistrasi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewRegistrasi.Columns["edit"].Index)
            {
                var row = dataGridViewRegistrasi.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                string outlet = row.Cells["nama_outlet"].Value.ToString();
                string nama = row.Cells["nama_member"].Value.ToString();
                string alamat = row.Cells["alamat"].Value.ToString();
                string jk = row.Cells["jenis_kelamin"].Value.ToString();
                string tlp = row.Cells["tlp"].Value.ToString();
                new EditDataPelanggan(btn_refresh, id, outlet,  nama, alamat, jk, tlp).ShowDialog();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            new RegistrasiPelanggan(btn_refresh).ShowDialog();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (txtCari.Text.Length > 0)
             CariData(txtCari.Text);
        }
    }
}
