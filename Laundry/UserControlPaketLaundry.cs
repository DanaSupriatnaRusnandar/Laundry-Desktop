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
         //   SELECT tb_paket.id, tb_outlet.nama_outlet ,tb_paket.nama_paket, tb_jenis.jenis, tb_paket.harga FROM tb_paket INNER JOIN tb_outlet on tb_paket.id_outlet = tb_outlet.id INNER JOIN tb_jenis ON tb_paket.id_jenis = tb_jenis.id
            dataGridViewpaket.AutoGenerateColumns = false;
            dataGridViewpaket.DataSource = Db.Read($"SELECT * FROM tb_paket JOIN tb_outlet ON tb_paket.id_outlet = tb_outlet.id JOIN tb_jenis ON tb_paket.id_jenis = tb_jenis.id WHERE tb_paket.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")}");
        }
        
        private void CariData(string keyword)
        {
            dataGridViewpaket.AutoGenerateColumns = false;
            dataGridViewpaket.DataSource = Db.Read($"SELECT * FROM tb_paket JOIN tb_outlet ON tb_paket.id_outlet = tb_outlet.id JOIN tb_jenis ON tb_paket.id_jenis = tb_jenis.id WHERE tb_paket.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")} AND tb_outlet.nama_outlet LIKE '%{keyword}%' OR tb_paket.nama_paket LIKE '%{keyword}%' OR tb_jenis.jenis LIKE '%{keyword}%'");
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
    }
}
