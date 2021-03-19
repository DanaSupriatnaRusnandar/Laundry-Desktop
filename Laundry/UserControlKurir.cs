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
            DataTable data = Db.Read($"SELECT * FROM tb_kurir JOIN tb_outlet on tb_kurir.id_outlet = tb_outlet.id WHERE tb_kurir.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")}");
            dataGridViewKurir.AutoGenerateColumns = false;
            dataGridViewKurir.DataSource = data;
        }

        private void CariData(string keyword)
        {
            dataGridViewKurir.AutoGenerateColumns = false;
            dataGridViewKurir.DataSource = Db.Read($"SELECT * FROM tb_kurir JOIN tb_outlet on tb_kurir.id_outlet = tb_outlet.id WHERE tb_kurir.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")} AND tb_kurir.nama_kurir LIKE '%{keyword}%' OR tb_kurir.alamat LIKE '%{keyword}%' OR tb_kurir.tlp LIKE '%{keyword}%' OR tb_outlet.nama_outlet LIKE '%{keyword}%'");
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
    }
}
