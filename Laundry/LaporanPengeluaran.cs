using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Luthor.lib;

namespace Laundry
{
    public partial class LaporanPengeluaran : Form
    {
        public LaporanPengeluaran()
        {
            InitializeComponent();
        }

        private void LaporanPengeluaran_Load(object sender, EventArgs e)
        {
            cmbOutlet.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
            cmbOutlet.DisplayMember = "nama_outlet";
            cmbOutlet.ValueMember = "id";
            cmbOutlet.SelectedIndex = -1;

            // TODO: This line of code loads data into the 'laundryDataSet.tb_pengeluaran' table. You can move, or remove it, as needed.
            this.DataTablePengeluaranTableAdapter.Fill(this.laundryDataSet.DataTablePengeluaran);
            // TODO: This line of code loads data into the 'laundryDataSet.DataTablePengeluaran' table. You can move, or remove it, as needed.
            this.DataTablePengeluaranTableAdapter.Fill(this.laundryDataSet.DataTablePengeluaran);

            this.reportViewer.RefreshReport();
        }
    }
}
