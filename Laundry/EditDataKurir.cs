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
    public partial class EditDataKurir : Form
    {
        Button btrf;
        string getIdKurir;
        public EditDataKurir(Button btrefresh, string id, string nama_kurir, string alamat, string tlp, string outlet)
        {
            InitializeComponent();
            btrf = btrefresh;
            getIdKurir = id;
            txtnama.Text = nama_kurir;
            txtAlamat.Text = alamat;
            txtTlp.Text = tlp;
            cmbOutlet.SelectedItem = outlet;
        }

        private void EditDataKurir_Load(object sender, EventArgs e)
        {
            //Biding Outlet
            cmbOutlet.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
            cmbOutlet.DisplayMember = "nama_outlet";
            cmbOutlet.ValueMember = "id";
            cmbOutlet.SelectedIndex = -1;
        }  

        private bool isfilled()
        {
            if (txtnama.Text.Length > 0 && txtAlamat.Text.Length > 0 && txtTlp.Text.Length > 0 && cmbOutlet.SelectedIndex >= 0) return true;
            return false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                var nama = txtnama.Text;
                var alamat = txtAlamat.Text;
                var tlp = txtTlp.Text;
                if (cmbOutlet.SelectedIndex == 0) ;
                var outlet = cmbOutlet.SelectedValue;

                if (Db.Update($"tb_kurir", $"id = {getIdKurir}, nama_kurir = '{nama}', alamat = '{alamat}', tlp = '{tlp}', id_outlet = '{outlet}'", $"id = {getIdKurir}"))
                {
                    MessageBox.Show("Data kurir berhasil diubah");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal mengubah data kurir. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
    }
}
