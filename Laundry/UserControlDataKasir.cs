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
    public partial class UserControlDataKasir : UserControl
    {
        public UserControlDataKasir()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            TambahDataKasir kasir = new TambahDataKasir();
            kasir.Show();
        }
    }
}
