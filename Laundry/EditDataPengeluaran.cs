using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Luthor.lib;

namespace Laundry
{
    public partial class EditDataPengeluaran : Form
    {
        Button btrf;
        string getIdPengeluaran;
        string nama_outlet;

        public EditDataPengeluaran(Button btrefresh, string id, string outlet, string nama, string tgl, string total, string keterangan)
        {
            InitializeComponent();
            getIdPengeluaran = id;
            nama_outlet = outlet;
            txtNamaBarang.Text = nama;
            dateTimePicker.Value = DateTime.Parse("yyyy/MM/dd");
            txtNominal.Text = total;
            txtKeterangan.Text = keterangan;
        }

        /*public EditDataPengeluaran(IconButton btn_refresh, string id, string outlet, string nama, string tgl, string total, string keterangan)
        {
            Btn_refresh = btn_refresh;
            Id = id;
            Outlet = outlet;
            Nama = nama;
            Tgl = tgl;
            Total = total;
            Keterangan = keterangan;
        }*/

        private void EditDataPengeluaran_Load(object sender, EventArgs e)
        {
            // Biding Outlet
            cmbOutlet.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
            cmbOutlet.DisplayMember = "nama_outlet";
            cmbOutlet.ValueMember = "id";
            cmbOutlet.SelectedIndex = -1;

            cmbOutlet.SelectedIndex = cmbOutlet.FindStringExact(nama_outlet);
        }

        private bool isfilled()
        {
            if (cmbOutlet.SelectedIndex >= 0 && txtNamaBarang.Text.Length >= 0 && dateTimePicker.Checked && txtNominal.Text.Length >= 0 && txtKeterangan.Text.Length >= 0) return true;
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                if (cmbOutlet.SelectedIndex == 0) ;
                var outlet = cmbOutlet.SelectedValue;
                var nama = txtNamaBarang.Text;
                var tgl = dateTimePicker.Value.ToString("yyyy-MMMM-dd");
                var nominal = txtNominal.Text;
                var keterangan = txtKeterangan.Text;

                if (Db.Insert($"tb_pengeluaran", $"id = {getIdPengeluaran}, nama_outlet = '{outlet}', nama_barang = '{nama}', tgl = '{tgl}', total = '{nominal}', keterangan = '{keterangan}'"))
                {
                    MessageBox.Show("Data pengeluaran berhasil diubah");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal mengubah data pengeluaran. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
