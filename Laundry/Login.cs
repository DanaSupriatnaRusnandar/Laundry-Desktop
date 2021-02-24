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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                if (Auth.Login(txtUsername.Text, Sha256.Encrypt(txtPassword.Text), "tb_user"))
                {
                    Form Dashboar = new DashboardAdmin();
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
    }
}
