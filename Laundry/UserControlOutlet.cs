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
    public partial class UserControlOutlet : UserControl
    {
        public UserControlOutlet()
        {
            InitializeComponent();
        }
        string getIdOutlet;

        private void UserControlOutlet_Load(object sender, EventArgs e)
        {
            dataGridViewOtlet.BorderStyle = BorderStyle.None;
            dataGridViewOtlet.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewOtlet.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewOtlet.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewOtlet.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewOtlet.BackgroundColor = Color.White;

            dataGridViewOtlet.EnableHeadersVisualStyles = false;
            dataGridViewOtlet.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewOtlet.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewOtlet.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            Tampilkan();
        }

        public void Tampilkan()
        {
            DataTable data = Db.Read("tb_outlet", "*");
            dataGridViewOtlet.AutoGenerateColumns = false;
            dataGridViewOtlet.DataSource = data;
        }

        private void CariData(string keyword)
        {
            dataGridViewOtlet.AutoGenerateColumns = false;
            dataGridViewOtlet.DataSource = Db.Read($"SELECT * FROM tb_outlet WHERE tb_outlet.nama_outlet LIKE '%{keyword}%' OR tb_outlet.alamat LIKE '%{keyword}%' OR tb_outlet.tlp LIKE '%{keyword}%'");
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

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin menghapus data outlet Ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_outlet", $"id = {getIdOutlet}");
                Tampilkan();
                MessageBox.Show("Data outlet berhasil dihapus!");

            }
        }

        //Event Hapus
        private void dataGridViewOtlet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewOtlet.CurrentCell.RowIndex;
            getIdOutlet = dataGridViewOtlet.Rows[row].Cells["id"].Value.ToString();
        }

        //Event Edit
        private void dataGridViewOtlet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewOtlet.Columns["edit"].Index)
            {
                var row = dataGridViewOtlet.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                string nama = row.Cells["nama_outlet"].Value.ToString();
                string alamat = row.Cells["alamat"].Value.ToString();
                string tlp = row.Cells["tlp"].Value.ToString();
                new EditDataOutlet(btn_refresh, id, nama, alamat, tlp).ShowDialog();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            new TambahDataOutlet(btn_refresh).ShowDialog();
        }
    }
}
