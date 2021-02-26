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
    public partial class PaketLaundry : Form
    {
        Button btrf;
        string id_outlet;
        
        public PaketLaundry(UserControlPaketLaundry parent, Button btrefresh, string Outlet)
        {
            InitializeComponent();
            id_outlet = Outlet;
            btrf = btrefresh;
        }

        private bool isfilled()
        {
            if (cmbJenis.SelectedIndex > 0 && txtNama.Text.Length > 0 && txtHarga.Text.Length > 0) return true;
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                if (Db.Insert("tb_paket", $"null, '{id_outlet}', '{cmbJenis.SelectedItem}', '{txtNama.Text}', '{txtHarga.Text}'"))
                {
                    MessageBox.Show("Paket berhasil ditambah");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal Menambah paket. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
