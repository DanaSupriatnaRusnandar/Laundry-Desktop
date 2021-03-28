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

namespace Laundry.TambahData
{
    public partial class TambahDataOutlet : Form
    {
        Button btrf;
        Validasi validasi = new Validasi();
        public TambahDataOutlet(Button btrefresh)
        {
            InitializeComponent();
            btrf = btrefresh;
        }

        private void TambahDataOutlet_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
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
                var nama = txtnama.Text;
                var alamat = txtAlamat.Text;
                var tlp = txtNoTelepon.Text;
                if (Db.Insert("tb_outlet", $"NULL, '{nama}', '{alamat}', '{tlp}'"))
                {

                    MessageBox.Show("Outlet berhasil di tambahkan");
                    btrf.PerformClick();
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Gagal menambah outlet \n\n ERROR MESSAGE : \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNoTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            validasi.Angka(e);
        }
    }
}
