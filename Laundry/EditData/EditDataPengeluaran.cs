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
        string IdOutlet;
        string nama_outlet;
        Validasi validasi = new Validasi();
        public EditDataPengeluaran(Button btrefresh, string id, string id_outlet, string outlet, string nama, DateTime tgl, string total, string keterangan)
        {
            InitializeComponent();
            btrf = btrefresh;
            getIdPengeluaran = id;
            IdOutlet = id_outlet;
            nama_outlet = outlet;
            txtNamaBarang.Text = nama;
            dateTimePicker.Value = tgl;
            txtNominal.Text = total;
            txtKeterangan.Text = keterangan;
        }

        private void EditDataPengeluaran_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            cmbOutle.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
            cmbOutle.DisplayMember = "nama_outlet";
            cmbOutle.ValueMember = "id";
            cmbOutle.SelectedIndex = -1;

            if (Session.getUserLogged().Rows[0].Field<string>("role") != "admin")
            {
                panelOutlet.Visible = false;
            }

            cmbOutle.SelectedIndex = cmbOutle.FindStringExact(nama_outlet);
        }

        private bool isfilled()
        {
            if (txtNamaBarang.Text.Length >= 0 && dateTimePicker.Checked && txtNominal.Text.Length >= 0 && txtKeterangan.Text.Length >= 0 && cmbOutle.SelectedIndex >= 0) return true;
            return false;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (isfilled())
            {
                var outlet = Session.getUserLogged().Rows[0].Field<int>("id_outlet");
                var nama = txtNamaBarang.Text;
                var tgl = dateTimePicker.Value.ToString("yyyy-MM-dd");
                var nominal = txtNominal.Text;
                var keterangan = txtKeterangan.Text;

                if (Db.Update($"tb_pengeluaran", $"id = '{getIdPengeluaran}', id_outlet = '{outlet}', nama_barang = '{nama}', tgl = '{tgl}', harga = '{nominal}', keterangan = '{keterangan}'", $"id = {getIdPengeluaran}"))
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

        private void txtNominal_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validasi.Angka(sender, e);
        }
    }
}
