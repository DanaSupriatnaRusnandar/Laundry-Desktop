﻿using System;
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
    public partial class LaporanTransaksi : Form
    {
        public LaporanTransaksi()
        {
            InitializeComponent();
        }

        private void LaporanPengeluaran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laundryDataSet.tb_transaksi' table. You can move, or remove it, as needed.
            this.tb_transaksiTableAdapter.Fill(this.laundryDataSet.tb_transaksi);

            this.reportViewer1.RefreshReport();
        }
    }
}
