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
    public partial class UserControlLaporanTransaksi : UserControl
    {
        public UserControlLaporanTransaksi()
        {
            InitializeComponent();
        }

        private void UserControlLaporanTransaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laundryDataSet.tb_pengeluaran' table. You can move, or remove it, as needed.
            /*this.DataTableTransaksiTableAdapter.Fill(this.laundryDataSet.DataTableTransaksi, Convert.ToDateTime(dateTimePickerDari.Value.ToShortDateString()), Convert.ToDateTime(dateTimePickerSampai.Value.ToShortDateString()));
            this.reportViewer1.RefreshReport();*/
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            /*DataTable data = Db.Read($"SELECT * FROM tb_transaksi join tb_outlet on tb_transaksi.id_outlet = tb_outlet.id JOIN tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_kurir ON tb_transaksi.id_kurir = tb_kurir.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id WHERE tb_transaksi.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")} ORDER BY tb_transaksi.id DESC");
            ReportDataSource rds = new ReportDataSource("DataTablePengeluaran", data);
            reportViewer1.LocalReport.ReportPath = @"D:\Belajar Pemrograman\C#\Laundry\Laundry\ReportTransaksi.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();*/

            // TODO: This line of code loads data into the 'laundryDataSet.DataTablePengeluaran' table. You can move, or remove it, as needed.
            this.DataTableTransaksiTableAdapter.Fill(this.laundryDataSet.DataTableTransaksi, Convert.ToDateTime(dateTimePickerDari.Value.ToShortDateString()), Convert.ToDateTime(dateTimePickerSampai.Value.ToShortDateString()));
            this.reportViewer1.RefreshReport();
        }
    }
}
