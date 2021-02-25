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
    public partial class TambahDataAdmin : Form
    {
        Button btrf;
        public TambahDataAdmin(UserControlDataAdmin parent, Button btrefresh)
        {
            InitializeComponent();
            btrf = btrefresh;
        }

        private bool isfilled()
        {
            if (txtnama.Text.Length > 0 && txtusername.Text.Length > 0 && txtpassword.Text.Length > 0 && txtRole.Text.Length > 0) return true;
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                var nama = txtnama.Text;
                var username = txtusername.Text;
                var password = txtpassword;
                var hak_akses = txtRole.Text;

                if (Db.Insert("tb_user", $"null, '{nama}', '{username}', '{password}', '{hak_akses}'"))
                {
                    MessageBox.Show("User berhasil ditambah");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal Menambah User. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
