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
    public partial class TambahDataOutlet : Form
    {
        Button btrf;
        public TambahDataOutlet(UserControlOutlet parent ,Button btrefresh)
        {
            InitializeComponent();
            btrf = btrefresh;
        }

        private bool isfilled()
        {
            if (txtnama.Text.Length > 0 && txtAlamat.Text.Length > 0 && txtNoTelepon.Text.Length > 0) return true;
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                string nama = txtnama.Text;
                string alamat = txtAlamat.Text;
                string tlp = txtNoTelepon.Text;

                if (Db.Insert("tb_outlet", $"NULL, '{txtnama}', '{txtAlamat}', '{txtNoTelepon}'"))
                {
                    MessageBox.Show("Outlet berhasil di tambahkan");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Gagal menambah outlet \n\n ERROR MESSAGE : \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
