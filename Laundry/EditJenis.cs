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
    public partial class EditJenis : Form
    {
        Button btrf;
        string getIdJenis;
        public EditJenis(Button btrefresh, string id, string jenis)
        {
            InitializeComponent();
            btrf = btrefresh;
            getIdJenis = id;
            txtEdit.Text = jenis;
        }

        private bool isFilled()
        {
            if (txtEdit.Text.Length > 0) return true;
            return false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                var jenis = txtEdit.Text;
                if (Db.Update($"tb_jenis", $"id = '{getIdJenis}', jenis = '{jenis}'", $"id = {getIdJenis}"))
                {
                    MessageBox.Show("Data jenis berhasil diubah");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal mengubah data jenis. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
