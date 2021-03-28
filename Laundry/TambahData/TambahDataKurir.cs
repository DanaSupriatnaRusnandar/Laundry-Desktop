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
        Button btrf;
        Validasi val = new Validasi();
        public TambahDataKurir(Button btrefresh)
        {
            InitializeComponent();
            btrf = btrefresh;
        }

        private void TambahDataKurir_Load(object sender, EventArgs e)
        {
            //Biding Outlet
            cmbOutle.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
            cmbOutle.DisplayMember = "nama_outlet";
            cmbOutle.ValueMember = "id";
            cmbOutle.SelectedIndex = -1;

            this.KeyPreview = true;
        }

        private bool isfilled()
        {
            if (txtnama.Text.Length > 0 && txtAlamat.Text.Length > 0 && txtTlp.Text.Length > 0) return true;
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                var nama = txtnama.Text;
                var alamat = txtAlamat.Text;
                var tlp = txtTlp.Text;
                var outlet = Session.getUserLogged().Rows[0].Field<int>("id_outlet");

                if ( Db.Insert("tb_kurir", $"Null, '{nama}', '{alamat}', '{tlp}', '{outlet}'"))
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

        private void txtTlp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
