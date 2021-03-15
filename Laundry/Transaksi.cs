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
        string getIdTransaksi;
        public Transaksi(Button btrefresh, string id)
        {
            InitializeComponent();
            btrf = btrefresh;
            getIdTransaksi = id;
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

            //Biding status
            /*cmbStatus.DataSource = Db.Read("tb_transaksi", "id, status");
            cmbStatus.DisplayMember = "status";
            cmbStatus.ValueMember = "id";
            cmbStatus.SelectedIndex = -1;*/
            Status();
            Dibayar();
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

        private void hitungTotalPembayaran()
        {
            int.TryParse(txtHarga.Text, out int harga);
            int.TryParse(txtQty.Text, out int qty);
            double.TryParse(txtDiskon.Text, out double diskon);
            int.TryParse(txtNominalDiskon.Text, out int NominalDiskon);
            double.TryParse(txtNominalPajak.Text, out double pajak);
            int.TryParse(txtNominalPajak.Text, out int NominalPajak);
            int.TryParse(txtBiayaTambahan.Text, out int biayaTambahan);

            //Total
            int total = harga * qty;
            txtTotal.Text = total.ToString();

            //Diskon
            diskon = 0.01;
            NominalDiskon = (int)(total * diskon);
            txtNominalDiskon.Text = NominalDiskon.ToString();


            //Pajak
            pajak = 0.01;
            NominalPajak = (int)(total * pajak);
            txtNominalPajak.Text = NominalPajak.ToString();

            //Total Pembayaran
            int TotalPembayaran = total - NominalDiskon + NominalPajak + biayaTambahan;
            txtTotalPembayaran.Text = TotalPembayaran.ToString();
        }

        private bool isfilled()
        {
            if (cmbOutlet.SelectedIndex >= 0 && cmbPelanggan.SelectedIndex >= 0 && dtpTanggal.Checked && dtpBatasWaktu.Checked && cmbPaket.SelectedIndex >= 0 && txtHarga.Text.Length >= 0 && txtDiskon.Text.Length >= 0 && txtBiayaTambahan.Text.Length >= 0 && txtPajak.Text.Length >= 0 && txtTotal.Text.Length >= 0 && cmbDibayar.SelectedIndex >= 0 && dtpTanggalBayar.Checked && cmbStatus.SelectedIndex >= 0 && txtCatatan.Text.Length >= 0 && cmbKurir.SelectedIndex >= 0 && cmbPetugas.SelectedIndex >= 0) return true;
            return false;
        }

        void Status()
        {
            cmbDibayar.Items.Add("baru");
            cmbDibayar.Items.Add("proses");
            cmbDibayar.Items.Add("selesai");
            cmbDibayar.Items.Add("diambil");
        }

        void Dibayar()
        {
            cmbDibayar.Items.Add("dibayar");
            cmbDibayar.Items.Add("belum dibayar");       
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new RegistrasiPelanggan(btn_refresh).ShowDialog();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                if (cmbOutlet.SelectedIndex == 0) ;
                var outlet = cmbOutlet.SelectedValue;
                if (cmbPelanggan.SelectedIndex == 0) ;
                var pelanggan = cmbPelanggan.SelectedValue;
                var tanggal = dtpTanggal.Value.ToString("yyyy-MM-dd");
                var batasWaktu = dtpBatasWaktu.Value.ToString("yyyy-MM-dd");
                if (cmbPaket.SelectedIndex == 0) ;
                var paket = cmbPaket.SelectedValue;
                var jenis = txtJenis.Text;
                var qty = txtQty.Text;
                var harga = txtHarga.Text;
                var diskon = txtDiskon.Text;
                var biayaTambahan = txtBiayaTambahan.Text;
                var pajak = txtPajak.Text;
                var total = txtTotal.Text;
                if (cmbDibayar.SelectedIndex == 0) ;
                var dibayar = cmbDibayar.SelectedItem;
                var tanggalBayar = dtpTanggalBayar.Value.ToString("yyyy-MM-dd");
                if (cmbStatus.SelectedIndex == 0) ;
                var status = cmbStatus.SelectedItem;
                var catatan = txtCatatan.Text;
                if (cmbKurir.SelectedIndex == 0) ;
                var kurir = cmbKurir.SelectedValue;
                if (cmbPetugas.SelectedIndex == 0) ;
                var petugas = cmbPetugas.SelectedValue;

                //SELECT * FROM tb_transaksi JOIN tb_outlet ON tb_transaksi.id_outlet = tb_outlet.id join tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_kurir ON tb_transaksi.id_kurir = tb_kurir.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id JOIN tb_detail_transaksi ON tb_detail_transaksi.id_transaksi = tb_transaksi.id JOIN tb_paket ON tb_detail_transaksi.id_paket = tb_paket.id
                if (Db.Insert($"tb_transaksi", $"Null, '{outlet}', '{pelanggan}', '{tanggal}', '{batasWaktu}', '{paket}', '{jenis}', '{qty}', '{harga}', '{diskon}', '{biayaTambahan}', '{pajak}', '{total}', '{dibayar}', '{tanggalBayar}', '{status}', '{catatan}', '{kurir}', '{petugas}'"))
                {
                    MessageBox.Show("Transaksi berhasil dilakukan");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal melakukan transaksi. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbPaket_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataPaket();
        }
        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            hitungTotalPembayaran();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            hitungTotalPembayaran();
        }

        private void txtDiskon_TextChanged(object sender, EventArgs e)
        {
            txtDiskon.Text = txtNominalDiskon.Text;
        }
    }
}
