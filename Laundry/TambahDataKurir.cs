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
    public partial class TambahDataKurir : Form
    {
        public TambahDataKurir(Button btrefresh)
        {
            InitializeComponent();
            btrf = btrefresh;
        }
        Button btrf;

        private bool isfilled()
        {
            if (txtnama.Text.Length > 0 && txtAlamat.Text.Length > 0 && txtTlp.Text.Length > 0 && cmbOutlet.SelectedIndex >= 0) return true;
            return false;
        }

        private void TambahDataKurir_Load(object sender, EventArgs e)
        {
            //Biding Outlet
            cmbOutlet.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
            cmbOutlet.DisplayMember = "nama_outlet";
            cmbOutlet.ValueMember = "id";
            cmbOutlet.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                var nama = txtnama.Text;
                var alamat = txtAlamat.Text;
                var tlp = txtTlp.Text;
                if (cmbOutlet.SelectedIndex == 0) ;
                var outlet = cmbOutlet.SelectedValue;

                if ( Db.Insert("tb_kurir",$"Null, '{nama}', '{alamat}', '{tlp}', '{outlet}'"))
                {
                    MessageBox.Show("Data kurir berhasil ditambah");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal Menambah kurir. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
