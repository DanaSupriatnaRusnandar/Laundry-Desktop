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
    public partial class UserControlLaporan : UserControl
    {
        public UserControlLaporan()
        {
            InitializeComponent();
        }

        private void UserControlLaporan_Load(object sender, EventArgs e)
        {
            dataGridViewLaporan.BorderStyle = BorderStyle.None;
            dataGridViewLaporan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewLaporan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewLaporan.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewLaporan.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewLaporan.BackgroundColor = Color.White;

            dataGridViewLaporan.EnableHeadersVisualStyles = false;
            dataGridViewLaporan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewLaporan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewLaporan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            // Laporan(cmbLaporan.SelectedItem);
            Tampilkan();

        }

        /*void Laporan(object laporan)
        {
            cmbLaporan.Items.Add("Berdasarkan kurir");
            cmbLaporan.Items.Add("Berdasarkan Petugas");

            Tampilkan();
        }*/

        private void Tampilkan()
        {
            DataTable data = Db.Read($"SELECT * FROM tb_transaksi JOIN tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_kurir ON tb_transaksi.id_kurir = tb_kurir.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id WHERE Date(tgl) BETWEEN '{dtpDari.Value.ToString("yyyy-MM-dd")}' AND '{dtpSampai.Value.ToString("yyyy-MM-dd")}'");
            dataGridViewLaporan.AutoGenerateColumns = false;
            dataGridViewLaporan.DataSource = data;
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            Tampilkan();
        }
    }
}
