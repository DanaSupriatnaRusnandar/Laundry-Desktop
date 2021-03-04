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
    public partial class Transaksi : Form
    {
        Button btrf;
        public Transaksi(Button btrefresh)
        {
            InitializeComponent();
            btrf = btrefresh;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new RegistrasiPelanggan(btnAdd).ShowDialog();
        }
    }
}
