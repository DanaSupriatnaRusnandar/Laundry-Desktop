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
            //ComboBox pelanggan
            txtCari.DataSource = Db.Read($"tb_outlet", "id, nama_outlet");
            txtCari.DisplayMember = "nama_outlet";
            txtCari.ValueMember = "id";
            txtCari.SelectedIndex = -1;

            dateTimePickerDari.Value = Convert.ToDateTime(dateTimePickerDari.Value.ToString("01/01/2021"));

            this.reportViewer1.RefreshReport();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
                this.dataTablePengeluaranTableAdapter1.Fill(this.laundryDataSet1.DataTablePengeluaran, Convert.ToDateTime(dateTimePickerDari.Value.ToShortDateString()), Convert.ToDateTime(dateTimePickerSampai.Value.ToShortDateString()), txtCari.Text);
                this.reportViewer1.RefreshReport();
        }
    }
}
