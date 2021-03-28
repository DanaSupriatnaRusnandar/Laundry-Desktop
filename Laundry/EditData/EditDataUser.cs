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
    public partial class EditDataUser : Form
    {
        Button btrf;
        string getIdUser;
        string idOutlet;
        string nama_outlet;
        string nama_role;
        Validasi validasi = new Validasi();
        public EditDataUser(Button btrefresh, string id, string nama, string username, string password,string id_outlet, string outlet, string role)
        {
            InitializeComponent();
            btrf = btrefresh;
            getIdUser = id;
            txtnama.Text = nama;
            txtusername.Text = username;
            //  txtpassword.Text = password;
            idOutlet = id_outlet;
            nama_outlet = outlet;
            nama_role = role;
        }

        private void EditDataUser_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //Biding Outlet
            cmbOutlet.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
            cmbOutlet.DisplayMember = "nama_outlet";
            cmbOutlet.ValueMember = "id";
            cmbOutlet.SelectedIndex = -1;
            
            if(Session.getUserLogged().Rows[0].Field<string>("role") == "superAdmin")
            {
                //Biding user
                cmbRole.DataSource = Db.Read("tb_user", "id, role");
                cmbRole.DisplayMember = "role";
                cmbRole.ValueMember = "id";
                cmbRole.SelectedIndex = -1;
            }
            else if (Session.getUserLogged().Rows[0].Field<string>("role") != "superAdmin")
            {
                //Biding user
                cmbRole.DataSource = Db.Read("tb_user", "id, role", $"tb_user.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")}");
                cmbRole.DisplayMember = "role";
                cmbRole.ValueMember = "id";
                cmbRole.SelectedIndex = -1;
            }


            cmbOutlet.SelectedIndex = cmbOutlet.FindStringExact(nama_outlet);
            cmbRole.SelectedIndex = cmbRole.FindStringExact(nama_role);
        }

        //Function
        private bool isfilled()
        {

            if (txtnama.Text.Length > 0 && txtusername.Text.Length > 0 && txtpassword.Text.Length > 0 && cmbOutlet.SelectedIndex >= 0 && cmbRole.SelectedIndex >= 0) return true;
            return false;
        }
        private bool isUsernameValid()
        {
            if (txtusername.Text.Contains(" ")) return false;
            return true;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        { 
            if (isfilled() && isUsernameValid())
            {
                var nama = txtnama.Text;
                var username = txtusername.Text;
                var password = Sha256.Encrypt(txtpassword.Text);
                var outlet = cmbOutlet.SelectedValue;
                var role = cmbRole.Text;
                if (Db.Update($"tb_user", $"id = '{getIdUser}', nama ='{nama}', username = '{username}', password = '{password}', id_outlet = '{outlet}' , role = '{role}'", $"id = {getIdUser}"))
                {
                    MessageBox.Show("Data user berhasil diubah");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal mengubah data user. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            if (isUsernameValid()) lblIsUsernameValid.Visible = false;
            else lblIsUsernameValid.Visible = true;
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
