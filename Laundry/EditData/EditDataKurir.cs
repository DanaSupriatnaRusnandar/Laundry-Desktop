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
    public partial class EditDataKurir : Form
    {
        Button btrf;
        string getIdKurir;
        string nama_outlet;
        Validasi validasi = new Validasi();
        public EditDataKurir(Button btrefresh, string id, string nama_kurir, string alamat, string tlp, string outlet)
        {
            InitializeComponent();
            btrf = btrefresh;
            getIdKurir = id;
            txtnama.Text = nama_kurir;
            txtAlamat.Text = alamat;
            txtTlp.Text = tlp;
            nama_outlet = outlet;
        }

        private void EditDataKurir_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //Biding Outlet
            cmbOutle.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
            cmbOutle.DisplayMember = "nama_outlet";
            cmbOutle.ValueMember = "id";
            cmbOutle.SelectedIndex = -1;

            cmbOutle.SelectedIndex = cmbOutle.FindStringExact(nama_outlet);
        }

        private bool isfilled()
        {
            if (txtnama.Text.Length > 0 && txtAlamat.Text.Length > 0 && txtTlp.Text.Length > 0) return true;
            return false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                var nama = txtnama.Text;
                var alamat = txtAlamat.Text;
                var tlp = txtTlp.Text;
                var outlet = Session.getUserLogged().Rows[0].Field<int>("id_outlet");

                if (Db.Update($"tb_kurir", $"id = {getIdKurir}, nama_kurir = '{nama}', alamat = '{alamat}', tlp = '{tlp}', id_outlet = '{outlet}'", $"id = {getIdKurir}"))
                {
                    MessageBox.Show("Data kurir berhasil diubah");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal mengubah data kurir. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTlp_KeyPress(object sender, KeyPressEventArgs e)
        {
            validasi.Angka(sender,e);
        }
    }
}
