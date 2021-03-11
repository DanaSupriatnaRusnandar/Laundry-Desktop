using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Luthor.lib;
using Luthor.lib.Encryption;

namespace Laundry
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private bool isUsernameValid()
        {
            if (txtUsername.Text.Contains(" ")) return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0 && isUsernameValid())
            {
             
               if(Auth.Login($"SELECT * FROM tb_user JOIN tb_role ON tb_user.id_role = tb_role.id WHERE username = {txtUsername.Text} AND password = {Sha256.Encrypt(txtPassword.Text)} AND nama_outlet = {"nama_outlet"}"))
                {
                    Form Dashboar = new Dashboard();
                    MessageBox.Show("Login Berhasil");
                    this.Hide();
                    Dashboar.Show();

                }
                else
                {
                    MessageBox.Show("Username atau Password salah!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (txtUsername.Text.Length == 0 && txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Masukan Username & Password!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtUsername.Text.Length == 0)
            {
                MessageBox.Show("Masukan Username!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Masukan Password!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtUsername_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (isUsernameValid()) lblIsUsernameValid.Visible = false;
            else lblIsUsernameValid.Visible = true;
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToLower(e.KeyChar);
        }
    }
}
