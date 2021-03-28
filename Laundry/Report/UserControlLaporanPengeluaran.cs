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
using Microsoft.Reporting.WinForms;

namespace Laundry
{
    public partial class UserControlLaporanPengeluaran: UserControl
    {
        public UserControlLaporanPengeluaran()
        {
            InitializeComponent();
        }

        private void UserControlLaporanPengeluaran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laundryDataSet.tb_pengeluaran' table. You can move, or remove it, as needed.
            /* this.DataTablePengeluaranTableAdapter.Fill(this.laundryDataSet.DataTablePengeluaran, dateTimePickerDari.Value.Date, dateTimePickerSampai.Value.Date);
             this.reportViewer1.RefreshReport();*/
            this.reportViewer1.RefreshReport();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            this.dataTablePengeluaranTableAdapter1.Fill(this.laundryDataSet1.DataTablePengeluaran, Convert.ToDateTime(dateTimePickerDari.Value.ToShortDateString()), Convert.ToDateTime(dateTimePickerSampai.Value.ToShortDateString()));
            this.reportViewer1.RefreshReport();
        }
    }
}
