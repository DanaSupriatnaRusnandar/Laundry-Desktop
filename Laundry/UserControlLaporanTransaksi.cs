using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry
{
    public partial class UserControlLaporanTransaksi : UserControl
    {
        public UserControlLaporanTransaksi()
        {
            InitializeComponent();
        }

        private void UserControlLaporanTransaksi_Load(object sender, EventArgs e)
        {
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laundryDataSet.DataTablePengeluaran' table. You can move, or remove it, as needed.
            this.DataTableTransaksiTableAdapter.Fill(this.laundryDataSet.DataTableTransaksi, Convert.ToDateTime(dateTimePickerDari.Value.ToShortDateString()), Convert.ToDateTime(dateTimePickerSampai.Value.ToShortDateString()));
            this.reportViewer1.RefreshReport();
        }
    }
}
