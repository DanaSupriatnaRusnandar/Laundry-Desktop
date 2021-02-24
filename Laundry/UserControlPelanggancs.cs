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
    public partial class UserControlPelanggancs : UserControl
    {
        public UserControlPelanggancs()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            RegistrasiPelanggan reg = new RegistrasiPelanggan();
            reg.Show();
        }
    }
}
