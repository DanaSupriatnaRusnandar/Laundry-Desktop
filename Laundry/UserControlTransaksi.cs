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
            //  DataTable data = Db.Read($"SELECT * FROM tb_transaksi join tb_outlet on tb_transaksi.id_outlet = tb_outlet.id JOIN tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_kurir ON tb_transaksi.id_kurir = tb_kurir.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id");
            /* dataGridViewTransaksi.Rows.Clear();
             foreach (DataRow row in data.Rows)
             {
                 dataGridViewTransaksi.Rows.Add($"NULL", $"NULL", row.Field<string>("kode_invoice"), $"NULL" ,row.Field<string>("alamat"), row.Field<string>("tlp"));
             }*/
            DataTable data = Db.Read($"SELECT * FROM tb_transaksi join tb_outlet on tb_transaksi.id_outlet = tb_outlet.id JOIN tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_kurir ON tb_transaksi.id_kurir = tb_kurir.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id");
            dataGridViewTransaksi.AutoGenerateColumns = false;
            dataGridViewTransaksi.DataSource = data;
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

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            new TambahTransaksi(btn_refresh, getIdTransaksi ).ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Tampilkan();
        }

        private void dataGridViewTransaksi_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           
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

            }
        }
    }
}
