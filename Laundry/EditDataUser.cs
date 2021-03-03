﻿using System;
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
        public EditDataUser(Button btrefresh, string id, string nama, string username, string password,string id_outlet, string outlet, string role)
        {
            InitializeComponent();
            btrf = btrefresh;
            getIdUser = id;
            txtnama.Text = nama;
            txtusername.Text = username;
            //  txtpassword.Text = password;
            idOutlet = id_outlet;
            cmbOutlet.SelectedItem = outlet;
            cmbRole.SelectedItem = role;
        }

        private void EditDataUser_Load(object sender, EventArgs e)
        {
            //Biding Outlet
            cmbOutlet.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
            cmbOutlet.DisplayMember = "nama_outlet";
            cmbOutlet.ValueMember = "id";
            cmbOutlet.SelectedIndex = -1;

            //Biding user
            cmbRole.DataSource = Db.Read("tb_role", "id, nama_role");
            cmbRole.DisplayMember = "nama_role";
            cmbRole.ValueMember = "id";
            cmbRole.SelectedIndex = -1;

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
                if (cmbOutlet.SelectedIndex == 0) ;
                var outlet = cmbOutlet.SelectedValue;
                if (cmbRole.SelectedIndex == 0) ;
                var role = cmbRole.SelectedValue;
                if (Db.Update($"tb_user", $"id = '{getIdUser}', nama ='{nama}', username = '{username}', password = '{password}', id_outlet = '{outlet}' , id_role = '{role}'", $"id = {getIdUser}"))
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
            e.KeyChar = Char.ToLower(e.KeyChar);
        }
    }
}
