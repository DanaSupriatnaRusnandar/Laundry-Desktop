using Luthor.lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry
{
    public partial class EditDataPelanggan : Form
    {
        Button btrf;
        string getIdPelanggan;
        public EditDataPelanggan(Button btrefresh, string id, string nama, string alamat, string jk, string tlp)
        {
            InitializeComponent();
            btrf = btrefresh;
            getIdPelanggan = id;
            txtnama.Text = nama;
            txtalamat.Text = alamat;
            txtJK.Text = jk;
            txtTelepon.Text = tlp;
            if (jk == "Laki - Laki") rbLaki.Checked = true;
            else rbPerempuan.Checked = true;
        }

        private void EditDataPelanggan_Load(object sender, EventArgs e)
        {

        }

        private bool isfilled()
        {
            if (txtnama.Text.Length < 0 && txtalamat.Text.Length < 0 && txtJK.Text.Length < 0 && txtTelepon.Text.Length < 0) return false;
            return true;
        }

        private void rbLaki_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLaki.Checked) txtJK.Text = "Laki - Laki";
        }

        private void rbPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPerempuan.Checked) txtJK.Text = "Perempuan";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                var nama = txtnama.Text;
                var alamat = txtalamat.Text;
                var JK = txtJK.Text;
                var tlp = txtTelepon.Text;
                if (Db.Update("tb_member", $"id = {getIdPelanggan}, nama_member = '{nama}', alamat = '{alamat}', jenis_kelamin = '{JK}', tlp = '{tlp}'", $"id = {getIdPelanggan}"))
                {
                    MessageBox.Show("Data pelanggan berhasil diubah");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal mengubah data pelanggan. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
