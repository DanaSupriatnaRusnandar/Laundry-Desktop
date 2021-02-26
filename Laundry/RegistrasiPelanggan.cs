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
    public partial class RegistrasiPelanggan : Form
    {
        Button btrf;
        public RegistrasiPelanggan(UserControlPelanggancs parent, Button btrefresh)
        {
            InitializeComponent();
            btrf = btrefresh;
        }

        private bool isfilled()
        {
            if (txtnama.Text.Length < 0 && txtalamat.Text.Length < 0 && textBoxJK.Text.Length < 0 && txtTelepon.Text.Length < 0) return false;
            return true;
        }

        private void radioButtonLaki_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLaki.Checked) textBoxJK.Text = "P";
        }

        private void radioButtonPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPerempuan.Checked) textBoxJK.Text = "L";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                if (Db.Insert("tb_member", $"NULL, '{txtnama.Text}', '{txtalamat.Text}', '{textBoxJK.Text}', '{txtTelepon.Text}'"))
                {
                    MessageBox.Show("Data pelanggan berhasil ditambah");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal Menambah pelanggan. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
