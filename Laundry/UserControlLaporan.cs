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
    public partial class UserControlLaporan : UserControl
    {
        public UserControlLaporan()
        {
            InitializeComponent();
        }

        private void UserControlLaporan_Load(object sender, EventArgs e)
        {
            reportViewer.RefreshReport();
        }

        private void Tampilkan()
        {
            DataTable data = Db.Read($"SELECT * FROM tb_transaksi JOIN tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_kurir ON tb_transaksi.id_kurir = tb_kurir.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id WHERE Date(tgl) BETWEEN '{dtpDari.Value.ToString("yyyy-MM-dd")}' AND '{dtpSampai.Value.ToString("yyyy-MM-dd")}'");
            ReportDataSource rds = new ReportDataSource("DataTableLaporan", data);
            reportViewer.LocalReport.ReportPath = @"D:\Belajar Pemrograman\C#\Laundry\Laundry\ReportLaporan.rdlc";
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);
            reportViewer.RefreshReport();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            Tampilkan();
        }
    }
}
