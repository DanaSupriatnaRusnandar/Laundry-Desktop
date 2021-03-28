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
    public partial class TambahDataPengeluaran : Form
    {
        Button btrf;
        string getIdPengeluaran;
        string outlet;
        Validasi validasi = new Validasi();
        public TambahDataPengeluaran(Button btrefresh, string id)
        {
            InitializeComponent();
            btrf = btrefresh;
            getIdPengeluaran = id;
        }

        private void TambahDataPengeluaran_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //Biding Outlet
            cmbOutle.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
            cmbOutle.DisplayMember = "nama_outlet";
            cmbOutle.ValueMember = "id";
            cmbOutle.SelectedIndex = -1;

            if (Session.getUserLogged().Rows[0].Field<string>("role") != "admin")
            {
                panelOutlet.Visible = false;
            }
        }

        private bool isfilled()
        {
            if (txtNamaBarang.Text.Length >= 0 && dateTimePicker.Checked && txtNominal.Text.Length >= 0 && txtKeterangan.Text.Length >= 0) return true;
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                var outlet = Session.getUserLogged().Rows[0].Field<int>("id_outlet");
                var nama = txtNamaBarang.Text;
                var tgl = dateTimePicker.Value.ToString("yyyy-MM-dd");
                var nominal = txtNominal.Text;
                var keterangan = txtKeterangan.Text;

                if (Db.Insert($"tb_pengeluaran", $"Null, '{outlet}', '{nama}', '{tgl}', '{nominal}', '{keterangan}'"))
                {
                    MessageBox.Show("Data pengeluaran berhasil ditambah");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal menambah data pengeluaran. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNominal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validasi.Angka(e);
        }
    }
}
