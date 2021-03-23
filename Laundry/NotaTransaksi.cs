using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry
{
    public partial class NotaTransaksi : Form
    {
        public NotaTransaksi()
        {
            InitializeComponent();
        }

        private void NotaTransaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laundryDataSet.tb_transaksi' table. You can move, or remove it, as needed.
            this.tb_transaksiTableAdapter.Fill(this.laundryDataSet.tb_transaksi);
            // TODO: This line of code loads data into the 'laundryDataSet.tb_member' table. You can move, or remove it, as needed.
            this.tb_memberTableAdapter.Fill(this.laundryDataSet.tb_member);
            // TODO: This line of code loads data into the 'laundryDataSet.tb_outlet' table. You can move, or remove it, as needed.
            this.tb_outletTableAdapter.Fill(this.laundryDataSet.tb_outlet);
            // TODO: This line of code loads data into the 'laundryDataSet.tb_paket' table. You can move, or remove it, as needed.
            this.tb_paketTableAdapter.Fill(this.laundryDataSet.tb_paket);
            // TODO: This line of code loads data into the 'laundryDataSet.tb_jenis' table. You can move, or remove it, as needed.
            this.tb_jenisTableAdapter.Fill(this.laundryDataSet.tb_jenis);
            // TODO: This line of code loads data into the 'laundryDataSet.tb_detail_transaksi' table. You can move, or remove it, as needed.
            this.tb_detail_transaksiTableAdapter.Fill(this.laundryDataSet.tb_detail_transaksi);
            // TODO: This line of code loads data into the 'laundryDataSet.tb_user' table. You can move, or remove it, as needed.
            this.tb_userTableAdapter.Fill(this.laundryDataSet.tb_user);
            // TODO: This line of code loads data into the 'laundryDataSet.tb_kurir' table. You can move, or remove it, as needed.
            this.tb_kurirTableAdapter.Fill(this.laundryDataSet.tb_kurir);
            // TODO: This line of code loads data into the 'laundryDataSet.DataTableNota' table. You can move, or remove it, as needed.
            this.DataTableNotaTableAdapter.Fill(this.laundryDataSet.DataTableNota);

            this.reportViewer1.RefreshReport();
        }
    }
}
