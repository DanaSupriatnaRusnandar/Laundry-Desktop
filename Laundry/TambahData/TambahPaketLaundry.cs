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
    public partial class TambahPaketLaundry : Form
    {
        Button btrf;
        string id_outlet;
        Validasi validasi = new Validasi();

        public TambahPaketLaundry(UserControlPaketLaundry parent, Button btrefresh, string Outlet)
        {
            InitializeComponent();
            id_outlet = Outlet;
            btrf = btrefresh;
        }

        private void PaketLaundry_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //Biding Jenis
            cmbJenis.DataSource = Db.Read("tb_jenis", "id, jenis");
            cmbJenis.DisplayMember = "jenis";
            cmbJenis.ValueMember = "id";
            cmbJenis.SelectedIndex = -1;

            //Biding Outlet
            cmbOutlet.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
            cmbOutlet.DisplayMember = "nama_outlet";
            cmbOutlet.ValueMember = "id";
            cmbOutlet.SelectedIndex = -1;
        }

        private bool isfilled()
        {
            if (cmbJenis.SelectedIndex >= 0 && txtNama.Text.Length > 0 && txtHarga.Text.Length > 0) return true;
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
                if (Db.Insert("tb_paket", $"null, '{outlet}', '{nama_paket}' , '{jenis}', '{harga}'"))
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

        private void txtHarga_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validasi.Angka(sender, e);
        }
    }
}
