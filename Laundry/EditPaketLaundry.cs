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
        Button btrf;
        string getIdPaket;
        string getIdjenis;
        string nama_outlet;
        string nama_jenis;
        public EditPaketLaundry(Button btrefresh, string id, string outlet, string nama_paket, string id_jenis, string jenis, string harga)
        {
            InitializeComponent();
            btrf = btrefresh;
            getIdPaket = id;
            nama_outlet = outlet;
            txtNama.Text = nama_paket;
            getIdjenis = id_jenis;
            nama_jenis = jenis;
            txtHarga.Text = harga;

        }

        private void EditPaketLaundry_Load(object sender, EventArgs e)
        {
            //Biding Jenis
            cmbJenis.DataSource = Db.Read("tb_jenis", "id, jenis");
            cmbJenis.DisplayMember = "jenis";
            cmbJenis.ValueMember = "id";
            cmbJenis.SelectedIndex = -1;

            cmbJenis.SelectedIndex = cmbJenis.FindStringExact(nama_jenis);
        }

        //Function
        public bool isfilled()
        {
            if (txtNama.Text.Length >= 0 && cmbJenis.SelectedIndex >= 0 && txtHarga.Text.Length >= 0) return true;
            return false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                var outlet = Session.getUserLogged().Rows[0].Field<int>("id_outlet");
                var jenis = cmbJenis.SelectedValue;
                var nama_paket = txtNama.Text;
                var harga = txtHarga.Text;
                if (Db.Update($"tb_paket", $"id = '{getIdPaket}', id_outlet = '{outlet}', nama_paket = '{nama_paket}', id_jenis ='{jenis}', harga = '{harga}'", $"id = {getIdPaket}"))
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
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
