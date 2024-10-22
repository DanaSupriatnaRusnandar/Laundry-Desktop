﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Luthor.lib;
using Luthor.lib.Encryption;

namespace Laundry
{
    public partial class Login : Form
    {
        Validasi validasi = new Validasi();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private bool isUsernameValid()
        {
            if (txtUsername.Text.Contains(" ")) return false;
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0 && isUsernameValid())
            {
                if (Auth.Login(txtUsername.Text, Sha256.Encrypt(txtPassword.Text),"tb_user"))
                {   
                    //Logging
                    Db.Insert("login_log", $"null, NOW(), {Session.getUserLogged().Rows[0].Field<int>("id")}");

                    Form menu = new MainMenu();
                    MessageBox.Show("Selamat datang", Session.getUserLogged().Rows[0].Field<string>("nama"));
                    this.Hide();
                    menu.ShowDialog();

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
            validasi.Huruf_Kecil(e);

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
