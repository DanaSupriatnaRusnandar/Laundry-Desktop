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
        public RegistrasiPelanggan(Button btrefresh)
        {
            InitializeComponent();
            btrf = btrefresh;
        }

        private void RegistrasiPelanggan_Load(object sender, EventArgs e)
        {
            //Biding Outlet
            cmbOutle.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
            cmbOutle.DisplayMember = "nama_outlet";
            cmbOutle.ValueMember = "id";
            cmbOutle.SelectedIndex = -1;
        }

        private bool isfilled()
        {
            if (txtnama.Text.Length < 0 && txtalamat.Text.Length < 0 && textBoxJK.Text.Length < 0 && txtTelepon.Text.Length < 0) return false;
            return true;
        }

        private void radioButtonLaki_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLaki.Checked) textBoxJK.Text = "Laki - Laki";
        }

        private void radioButtonPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPerempuan.Checked) textBoxJK.Text = "Perempuan";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                var nama = txtnama.Text;
                var alamat = txtalamat.Text;
                var JK = textBoxJK.Text;
                var tlp = txtTelepon.Text;
                var outlet = Session.getUserLogged().Rows[0].Field<int>("id_outlet");
                if (Db.Insert("tb_member", $"NULL, '{nama}', '{alamat}', '{JK}', '{tlp}', '{outlet}'"))
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

        private void txtTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
