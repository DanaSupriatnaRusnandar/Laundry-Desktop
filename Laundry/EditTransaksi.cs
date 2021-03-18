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
    public partial class EditTransaksi : Form
    {
        Button btrf;
        string getIdTransaksi;
        string getIdPaket;
        int petugas;
        string nama_outlet;
        string nama_pelanggan;
        string kode_invoice;
        string statusTransaksi;
        string pembayaran;
        string nama_kurir;
        string nama_petugas;
        public EditTransaksi(Button btrefresh, string id, string outlet, string invoice, string pelanggan, DateTime tgl, DateTime batas_waktu, DateTime tgl_bayar, string biaya_tambahan, string diskon, string pajak, string total, string status, string dibayar, string kurir, string petugas)
        {
            InitializeComponent();
            btrf = btrefresh;
            getIdTransaksi = id;
            nama_outlet = outlet;
            kode_invoice = invoice;
            nama_pelanggan = pelanggan;
            dtpTanggal.Value = tgl;
            dtpBatasWaktu.Value = batas_waktu;
            dtpTanggalBayar.Value = tgl_bayar;
            txtBiayaTambahan.Text = biaya_tambahan;
            txtNominalDiskon.Text = diskon;
            txtNominalPajak.Text = pajak;
            txtTotalPembayaran.Text = total;
            statusTransaksi = status;
            pembayaran = dibayar;
            nama_kurir = kurir;
            nama_petugas = petugas;
        }

        private void EditTransaksi_Load(object sender, EventArgs e)
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


            Dibayar();
            cmbOutlet.SelectedIndex = cmbOutlet.FindStringExact(nama_outlet);
            cmbPelanggan.SelectedIndex = cmbPelanggan.FindStringExact(nama_pelanggan);
            cmbDibayar.SelectedIndex = cmbDibayar.FindStringExact(pembayaran);
            cmbKurir.SelectedIndex = cmbKurir.FindStringExact(nama_kurir);

            //data
            DataTable data = Db.Read($"SELECT * FROM tb_detail_transaksi JOIN tb_transaksi ON tb_detail_transaksi.id_transaksi = tb_transaksi.id JOIN tb_paket ON tb_detail_transaksi.id_paket = tb_paket.id WHERE kode_invoice = '{kode_invoice}'");
            foreach (DataRow row in data.Rows)
            {
                dataGridView1.Rows.Add(row.Field<string>("nama_paket"), row.Field<double>("qty"), row.Field<int>("total_pembayaran"));
            }
            MessageBox.Show(data.Rows.Count.ToString());
        }
        
        void Dibayar()
        {
            cmbDibayar.Items.Add("dibayar");
            cmbDibayar.Items.Add("belum_dibayar");
        }

        private bool isfilled()
        {
            if (cmbOutlet.SelectedIndex >= 0 && cmbPelanggan.SelectedIndex >= 0 && dtpTanggal.Checked && dtpBatasWaktu.Checked && txtDiskon.Text.Length >= 0 && txtBiayaTambahan.Text.Length >= 0 && txtPajak.Text.Length >= 0 && cmbDibayar.SelectedIndex >= 0 && dtpTanggalBayar.Checked && txtCatatan.Text.Length >= 0 && cmbKurir.SelectedIndex >= 0) return true;
            return false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                var outlet = cmbOutlet.SelectedValue;
                var pelanggan = cmbPelanggan.SelectedValue;
                var tanggal = dtpTanggal.Value.ToString("yyyy-MM-dd");
                var batasWaktu = dtpBatasWaktu.Value.ToString("yyyy-MM-dd");
                var diskon = Convert.ToDouble(txtNominalDiskon.Text) / dataGridView1.Rows.Count;
                var biayaTambahan = Convert.ToDouble(txtBiayaTambahan.Text) / dataGridView1.Rows.Count;
                var pajak = Convert.ToDouble(txtNominalPajak.Text) / dataGridView1.Rows.Count;
                var dibayar = cmbDibayar.SelectedItem;
                var tanggalBayar = dtpTanggalBayar.Value.ToString("yyyy-MM-dd");
                var catatan = txtCatatan.Text;
                var kurir = cmbKurir.SelectedValue;
                var invoice = DateTime.Now.ToString("yyyyMMddmmss");
                petugas = Session.getUserLogged().Rows[0].Field<int>("id");
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    var total = dataGridView1.Rows[i].Cells["harga"].Value.ToString();

                    getIdPaket = dataGridView1.Rows[i].Cells["id"].Value.ToString();
                    if (Db.Insert($"tb_transaksi", $"Null, '{outlet}', '{invoice}', '{pelanggan}', '{tanggal}', '{batasWaktu}', '{tanggalBayar}', '{biayaTambahan}', '{diskon}', '{pajak}', '{total}', 'baru', '{dibayar}', '{kurir}', '{petugas}'"))
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
        }
    }
}
