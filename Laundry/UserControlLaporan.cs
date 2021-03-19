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
            Laporan(cmbLaporan.SelectedItem);
        }

        void Laporan(object laporan)
        {
            cmbLaporan.Items.Add("Berdasarkan jenis paket");
            cmbLaporan.Items.Add("Berdasarkan kurir");
            cmbLaporan.Items.Add("Berdasarkan Petugas");

            Tampilkan();
        }

        private void Tampilkan()
        {
            dataGridViewLaporan.AutoGenerateColumns = false;
            DataTable data = Db.Read($"");
            dataGridViewLaporan.DataSource = data;
        }

       
    }
}
