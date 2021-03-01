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
    public partial class UserControlPelanggancs : UserControl
    {
        public UserControlPelanggancs()
        {
            InitializeComponent();
        }
        string getIdPelanggan;

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            new RegistrasiPelanggan(this, btn_refresh).ShowDialog();
        }
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
            DataTable data = Db.Read("tb_member", "*");
            dataGridViewRegistrasi.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                dataGridViewRegistrasi.Rows.Add(row.Field<int>("id"), row.Field<string>("nama"), row.Field<string>("alamat"), row.Field<string>("jenis_kelamin"), row.Field<string>("tlp"));
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Tampilkan();
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
           /* int row = dataGridViewRegistrasi.CurrentCell.RowIndex;
            getIdPelanggan = dataGridViewRegistrasi.Rows[row].Cells["id"].Value.ToString();*/

            int row = dataGridViewRegistrasi.CurrentCell.RowIndex;
            getIdPelanggan = dataGridViewRegistrasi.Rows[row].Cells["id"].Value.ToString();
        }
    }
}
