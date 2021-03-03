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
    public partial class EditPaketLaundry : Form
    {
        string getIdPaket;
        string getIdjenis;
        Button btrf;
        public EditPaketLaundry(Button btrefresh, string id, string outlet, string nama_paket, string id_jenis, string jenis, string harga)
        {
            InitializeComponent();
            btrf = btrefresh;
            getIdPaket = id;
            cmbOutlet.SelectedItem = outlet;
            txtNama.Text = nama_paket;
            getIdjenis = id_jenis;
            cmbJenis.SelectedItem = jenis;
            txtHarga.Text = harga;

        }

        private void EditPaketLaundry_Load(object sender, EventArgs e)
        {
            // Biding outlet
            cmbOutlet.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
            cmbOutlet.DisplayMember = "nama_outlet";
            cmbOutlet.ValueMember = "id";
            cmbOutlet.SelectedIndex = -1;

            //Biding Jenis
            cmbJenis.DataSource = Db.Read("tb_jenis", "id, jenis");
            cmbJenis.DisplayMember = "jenis";
            cmbJenis.ValueMember = "id";
            cmbJenis.SelectedIndex = -1;

        }

        //Function
        private bool ishargaValid()
        {
            if (txtHarga.Text.Contains(" ")) return false;
            return true;
        }

        public bool isfilled()
        {
            if (cmbOutlet.SelectedIndex >= 0 && txtNama.Text.Length >= 0 && cmbJenis.SelectedIndex >= 0 && txtHarga.Text.Length >= 0) return true;
            return false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isfilled() && ishargaValid())
            {
                if (cmbOutlet.SelectedIndex == 0) ;
                var outlet = cmbOutlet.SelectedValue;
                if (cmbJenis.SelectedIndex == 0) ;
                var jenis = cmbJenis.SelectedValue;
                var nama_paket = txtNama.Text;
                var harga = txtHarga.Text;
                if (Db.Update($"tb_paket", $"id = '{getIdPaket}', id_outlet = '{outlet}, nama_paket = '{nama_paket}', id_jenis ='{jenis}', harga = '{harga}'", $"id = {getIdPaket}"))
                {
                    MessageBox.Show("Paket laundry berhasil diubah");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal mengubah paket laundry. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void lblIsUsernameValid_TextChanged(object sender, EventArgs e)
        {
            if (ishargaValid()) lblIsUsernameValid.Visible = false;
            else lblIsUsernameValid.Visible = true;
        }
    }
}
