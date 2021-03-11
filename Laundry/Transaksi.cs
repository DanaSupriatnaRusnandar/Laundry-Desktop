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
    public partial class Transaksi : Form
    {
        Button btrf;
        public Transaksi(Button btrefresh)
        {
            InitializeComponent();
            btrf = btrefresh;
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            //Biding Outlet
            cmbOutlet.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
            cmbOutlet.DisplayMember = "nama_outlet";
            cmbOutlet.ValueMember = "id";
            cmbOutlet.SelectedIndex = -1;
            
            //Biding Pelanggan
            cmbPelanggan.DataSource = Db.Read("tb_member", "id, nama_member");
            cmbPelanggan.DisplayMember = "nama_member";
            cmbPelanggan.ValueMember = "id";
            cmbPelanggan.SelectedIndex = -1;
            
            //Biding Paket
            cmbPaket.DataSource = Db.Read("tb_paket", "id, nama_paket");
            cmbPaket.DisplayMember = "nama_paket";
            cmbPaket.ValueMember = "id";
            cmbPaket.SelectedIndex = -1;

            //Biding Kurir
            cmbKurir.DataSource = Db.Read("tb_kurir", "id, nama_kurir");
            cmbKurir.DisplayMember = "nama_kurir";
            cmbKurir.ValueMember = "id";
            cmbKurir.SelectedIndex = -1;

            //Biding user
            cmbPetugas.DataSource = Db.Read("tb_user", "id, nama");
            cmbPetugas.DisplayMember = "nama";
            cmbPetugas.ValueMember = "id";
            cmbPetugas.SelectedIndex = -1;
        }

        private void dataPaket()
        {
            DataTable dt = Db.Read($"SELECT * FROM tb_paket JOIN tb_jenis on tb_paket.id_jenis = tb_jenis.id WHERE tb_paket.id = {cmbPaket.SelectedValue}");
            foreach (DataRow dr in dt.Rows)
            {
                txtJenis.Text = dr["jenis"].ToString();
                txtHarga.Text = dr["harga"].ToString();
            }
        }

        private void hitungTotal()
        {
            /*  int harga = Convert.ToInt32(txtHarga.Text);
              int qty = Convert.ToInt32(txtQty.Text);
              int diskon = Convert.ToInt32(txtDiskon.Text);
              int biayaTambahan = Convert.ToInt32(txtBiayaTambahan.Text);
              int pajak = Convert.ToInt32(txtPajak.Text);
              int total = (qty + biayaTambahan + pajak) - biayaTambahan;
              txtTotal.Text = total.ToString();*/

            int.TryParse(txtHarga.Text, out int harga);
            int.TryParse(txtQty.Text, out int qty);
            int.TryParse(txtDiskon.Text, out int diskon);
            int.TryParse(txtBiayaTambahan.Text, out int biayaTambahan);
            int.TryParse(txtPajak.Text, out int pajak);
            int total = (harga * qty) + (biayaTambahan + pajak) - diskon;
            txtTotal.Text = total.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new RegistrasiPelanggan(btn_refresh).ShowDialog();
        }

        private void cmbPaket_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataPaket();
        }

        private void cmbPaket_SelectionChangeCommitted(object sender, EventArgs e)
        {
         //   dataPaket();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            hitungTotal();
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            hitungTotal();
        }

        private void txtDiskon_TextChanged(object sender, EventArgs e)
        {
            hitungTotal();
        }

        private void txtBiayaTambahan_TextChanged(object sender, EventArgs e)
        {
            hitungTotal();
        }

        private void txtPajak_TextChanged(object sender, EventArgs e)
        {
            hitungTotal();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            hitungTotal();
        }

        private void txtGrandTotal_TextChanged(object sender, EventArgs e)
        {
            hitungTotal();
        }
    }
}
