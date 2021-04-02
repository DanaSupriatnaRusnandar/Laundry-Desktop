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
using Luthor.lib.Encryption;

namespace Laundry
{
    public partial class TambahDataUser : Form
    {
        Button btrf;
        string getIdUser;
        Validasi validasi = new Validasi();
        public TambahDataUser(Button btrefresh, string id)
        {
            InitializeComponent();
            btrf = btrefresh;
            getIdUser = id;
        }

        private void TambahDataUser_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //Biding Outlet
            cmbOutlet.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
            cmbOutlet.DisplayMember = "nama_outlet";
            cmbOutlet.ValueMember = "id";
            cmbOutlet.SelectedIndex = -1;

            Role();
        }

        private bool isfilled()
        {
            if ( txtnama.Text.Length > 0 && txtusername.Text.Length > 0 && txtpassword.Text.Length > 0 && cmbOutlet.SelectedIndex >= 0 &&cmbRole.SelectedIndex >= 0) return true;
            return false;
        }

        void Role()
        {
            cmbRole.Items.Add("admin"); 
            cmbRole.Items.Add("kasir"); 
            cmbRole.Items.Add("owner");
        }

        private bool isUsernameValid()
        {
            if (txtusername.Text.Contains(" ")) return false;
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isfilled() && isUsernameValid())
            {
                var nama = txtnama.Text;
                var username = txtusername.Text;
                var password = Sha256.Encrypt(txtpassword.Text);
                var outlet = cmbOutlet.SelectedValue;
                var role = cmbRole.SelectedItem;
                if (Db.Insert("tb_user", $"null, '{nama}', '{username}', '{password}', '{outlet}', '{role}'"))
                {
                    MessageBox.Show("Data user berhasil ditambah");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal Menambah User. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            validasi.Huruf_Kecil(e);
        }

        private void txtnama_KeyPress(object sender, KeyPressEventArgs e)
        {
            validasi.Huruf_Angka_Simbol_Spasi(e);
        }
    }
}
