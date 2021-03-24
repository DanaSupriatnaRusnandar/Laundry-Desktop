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
using Microsoft.Reporting.WinForms;

namespace Laundry
{
    public partial class NotaTransaksi : Form
    {
        string kode_invoice;
        public NotaTransaksi(string Invoice)
        {
            InitializeComponent();
            kode_invoice = Invoice;
            MessageBox.Show(Invoice);
        }

        private void NotaTransaksi_Load(object sender, EventArgs e)
        {
            this.DataTableStrukTableAdapter.Fill(this.laundryDataSet.DataTableStruk, kode_invoice);

             this.reportViewer1.RefreshReport();
        }
    }
}
