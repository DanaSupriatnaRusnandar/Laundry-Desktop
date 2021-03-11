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
        public TambahDataPengeluaran(Button btrefresh, string id)
        {
            InitializeComponent();
            btrf = btrefresh;
            getIdPengeluaran = id;
        }

        private void TambahDataPengeluaran_Load(object sender, EventArgs e)
        {
            //Biding Outlet
            cmbOutlet.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
            cmbOutlet.DisplayMember = "nama_outlet";
            cmbOutlet.ValueMember = "id";
            cmbOutlet.SelectedIndex = -1;
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
    }
}
