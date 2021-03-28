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
        Validasi validasi = new Validasi();
        public RegistrasiPelanggan(Button btrefresh)
        {
            InitializeComponent();
            btrf = btrefresh;
        }

        private void RegistrasiPelanggan_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //Biding Outlet
            cmbOutlet.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
            cmbOutlet.DisplayMember = "nama_outlet";
            cmbOutlet.ValueMember = "id";
            cmbOutlet.SelectedIndex = -1;

            if(Session.getUserLogged().Rows[0].Field<string>("role") != "admin")
            {
                panelOutlet.Visible = false;
            }
        }

        private bool isfilled()
        {
            if (txtNama.Text.Length < 0 && txtAlamat.Text.Length < 0 && txtJK.Text.Length < 0 && txtTlp.Text.Length < 0) return false;
            return true;
        }

        private void radioButtonLaki_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLaki.Checked) txtJK.Text = "Laki - Laki";
        }

        private void radioButtonPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPerempuan.Checked) txtJK.Text = "Perempuan";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                var nama = txtNama.Text;
                var alamat = txtAlamat.Text;
                var JK = txtJK.Text;
                var tlp = txtTlp.Text;
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

        private void txtTlp_KeyPress(object sender, KeyPressEventArgs e)
        {
            validasi.Angka(e);
        }
    }
}
