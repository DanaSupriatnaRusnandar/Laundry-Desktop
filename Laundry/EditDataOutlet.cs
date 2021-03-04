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
    public partial class EditDataOutlet : Form
    {
        Button btrf;
        string getIdOutlet;
        public EditDataOutlet(Button btrefresh, string id, string nama, string alamat, string tlp)
        {
            InitializeComponent();
            btrf = btrefresh;
            getIdOutlet = id;
            txtnama.Text = nama;
            txtAlamat.Text = alamat;
            txtNoTelepon.Text = tlp;
        }

        private bool isfilled()
        {
            if (txtnama.Text.Length > 0 && txtAlamat.Text.Length > 0 && txtNoTelepon.Text.Length > 0) return true;
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                var nama = txtnama.Text;
                var alamat = txtAlamat.Text;
                var tlp = txtNoTelepon.Text;
                if (Db.Update($"tb_outlet", $"id = {getIdOutlet}, nama_outlet ='{nama}', alamat = '{alamat}', tlp = '{tlp}'", $"id = {getIdOutlet}"))
                {
                    MessageBox.Show("Data outlet berhasil diubah");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Gagal mengubah data outlet \n\n ERROR MESSAGE : \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
