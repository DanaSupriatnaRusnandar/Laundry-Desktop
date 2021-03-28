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
using Microsoft.Reporting.WinForms;
namespace Laundry
{
    public partial class TambahTransaksi : Form
    {
        Button btrf;
        string getIdTransaksi;
        string getIdPaket;
        int Total;
        int petugas;
        int id_outlet;
        int id_user;
        string Invoice;
        Validasi Validasi = new Validasi();
        public TambahTransaksi(Button btrefresh, string id)
        {
            InitializeComponent();
            btrf = btrefresh;
            getIdTransaksi = id;
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            if (Session.getUserLogged().Rows[0].Field<string>("role") == "admin")
            {
                this.KeyPreview = true;
                //ComboBox pelanggan
                cmbPelanggan.DataSource = Db.Read($"tb_member", "id, nama_member");
                cmbPelanggan.DisplayMember = "nama_member";
                cmbPelanggan.ValueMember = "id";
                cmbPelanggan.SelectedIndex = -1;

                //ComboBox Paket
                cmbPaket.DataSource = Db.Read("tb_paket", "id, nama_paket");
                cmbPaket.DisplayMember = "nama_paket";
                cmbPaket.ValueMember = "id";
                cmbPaket.SelectedIndex = -1;

                //ComboBox Kurir
                cmbKurir.DataSource = Db.Read("tb_kurir", "id, nama_kurir");
                cmbKurir.DisplayMember = "nama_kurir";
                cmbKurir.ValueMember = "id";
                cmbKurir.SelectedIndex = -1;
                
                //ComboBox Outlet
                cmbOutlet.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
                cmbOutlet.DisplayMember = "nama_outlet";
                cmbOutlet.ValueMember = "id";
                cmbOutlet.SelectedIndex = -1;
            }

            if (Session.getUserLogged().Rows[0].Field<string>("role") != "admin")
            {
                //ComboBox Pelanggan
                cmbPelanggan.DataSource = Db.Read($"tb_member", "id, nama_member", $"tb_member.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")}");
                cmbPelanggan.DisplayMember = "nama_member";
                cmbPelanggan.ValueMember = "id";
                cmbPelanggan.SelectedIndex = -1;

                //ComboBox Paket
                cmbPaket.DataSource = Db.Read("tb_paket", "id, nama_paket", $"tb_paket.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")}");
                cmbPaket.DisplayMember = "nama_paket";
                cmbPaket.ValueMember = "id";
                cmbPaket.SelectedIndex = -1;

                //ComboBox Kurir
                cmbKurir.DataSource = Db.Read($"tb_kurir", "id, nama_kurir", $"tb_kurir.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")}");
                cmbKurir.DisplayMember = "nama_kurir";
                cmbKurir.ValueMember = "id";
                cmbKurir.SelectedIndex = -1;

                cmbOutlet.Visible = false;
                lblOutlet.Visible = false;
            }


            id_outlet = Session.getUserLogged().Rows[0].Field<int>("id_outlet");
            id_user = Session.getUserLogged().Rows[0].Field<int>("id");

            Dibayar(cmbDibayar.SelectedItem);
        }

        //Panggil Data Paket
        private void dataPaket()
        {
            DataTable dt = Db.Read($"SELECT * FROM tb_paket JOIN tb_jenis on tb_paket.id_jenis = tb_jenis.id WHERE tb_paket.id = {cmbPaket.SelectedValue}");
            foreach (DataRow dr in dt.Rows)
            {
                txtJenis.Text = dr["jenis"].ToString();
                txtHarga.Text = dr["harga"].ToString();
            }
        }

        //TRANSAKSI
        private void hitungTotalPembayaran()
        {
            int.TryParse(txtHarga.Text, out int harga);
            int.TryParse(txtQty.Text, out int qty);
            double.TryParse(txtDiskon.Text, out double diskon);
            int.TryParse(txtNominalDiskon.Text, out int NominalDiskon);
            double.TryParse(txtNominalPajak.Text, out double pajak);
            int.TryParse(txtNominalPajak.Text, out int NominalPajak);
            int.TryParse(txtBiayaTambahan.Text, out int biayaTambahan);
            harga.ToString();

            //Total
            int total = harga * qty;
            txtTotal.Text = total.ToString();

            //Diskon
            if (txtDiskon.Text.Length > 0)
            {
                if (Convert.ToInt32(txtDiskon.Text) > 0)
                {
                    diskon = Total * (Convert.ToDouble(txtDiskon.Text) / 100);
                    txtNominalDiskon.Text = diskon.ToString();
                }
            }

            //Pajak
            if (txtPajak.Text.Length > 0)
            {
                if (Convert.ToInt32(txtPajak.Text) > 0)
                {
                    pajak = Total * (Convert.ToDouble(txtPajak.Text) / 100);
                    txtNominalPajak.Text = pajak.ToString();
                }
            }

            //Total Pembayaran
            double TotalPembayaran = Total - diskon + pajak + biayaTambahan;
            txtTotalPembayaran.Text = TotalPembayaran.ToString();
        }

        private void Hitungkerangjang()
        {
            if (dataGridView1.Rows.Count > 0 )
            {
                int HitungTotal = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    HitungTotal = HitungTotal + Convert.ToInt32(row.Cells["harga"].Value);
                }
                Total = HitungTotal;
                hitungTotalPembayaran();
            }
            else
            {
                txtTotalPembayaran.Text = "0";
            }
        }

        private bool isfilled()
        {
            if (cmbPelanggan.SelectedIndex >= 0 && dtpTanggal.Checked && dtpBatasWaktu.Checked && txtDiskon.Text.Length >= 0 && txtBiayaTambahan.Text.Length >= 0 && txtPajak.Text.Length >= 0 && cmbDibayar.SelectedIndex >= 0  && txtCatatan.Text.Length >= 0 && cmbKurir.SelectedIndex >= 0) return true;
            return false;
        }

        void Dibayar(object selectedItem)
        {
            cmbDibayar.Items.Add("dibayar");
            cmbDibayar.Items.Add("belum_dibayar");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new RegistrasiPelanggan(btn_refresh).ShowDialog();;
        }

        private void ClearData()
        {
            cmbPaket.SelectedIndex = -1;
            txtJenis.Clear();
            txtQty.Text = "1";
            txtHarga.Text = "0";
            txtTotal.Text = "0";
        }

        //Tambah Paket dataGridView
        private void btnTambahPaket_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(cmbPaket.SelectedValue, cmbPaket.Text, txtQty.Text, txtTotal.Text);
            ClearData();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                int next_id;
                DataTable result = Db.Read("SELECT id FROM tb_transaksi ORDER BY id DESC LIMIT 1");
                if (result.Rows.Count > 0) next_id = result.Rows[0].Field<int>("id") + 1;
                else next_id = 1;

                if (Db.ExecuteQuery($"ALTER TABLE tb_transaksi AUTO_INCREMENT = {next_id}"))
                {
                    Invoice = $"INV{DateTime.Now.ToString("yyMMddmmss")}";
                    string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    var diskon = Convert.ToDouble(txtNominalDiskon.Text) / dataGridView1.Rows.Count;
                    var biayaTambahan = Convert.ToDouble(txtBiayaTambahan.Text) / dataGridView1.Rows.Count;
                    var pajak = Convert.ToDouble(txtNominalPajak.Text) / dataGridView1.Rows.Count;
                    var dibayar = cmbDibayar.SelectedItem;
                    var kurir = cmbKurir.SelectedValue;
                    string tanggalBayar = "Null";
                    if (cmbDibayar.SelectedIndex == 0) tanggalBayar = $"'{now}'";
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string id_paket = row.Cells["id"].Value.ToString();
                        string qty = row.Cells["qty"].Value.ToString();
                        double total = Convert.ToDouble(row.Cells["harga"].Value) + pajak + biayaTambahan - diskon;
                        if (Db.ExecuteQuery(
                            $"CALL transaksi({next_id},{id_outlet},'{Invoice}', {cmbPelanggan.SelectedValue}, '{now}', '{dtpBatasWaktu.Value.ToString("yyyy/MM/dd")}', {tanggalBayar}, '{biayaTambahan}', '{diskon}', '{pajak}', 'baru', '{dibayar}', {id_user},  {id_paket}, '{qty}', '{txtCatatan.Text}', '{total}', '{kurir}')"
                            )) 
                        {
                            next_id++;
                        }
                        else
                        {
                            MessageBox.Show($"ERROR : {Error.error_msg}");
                        }
                    }
                    MessageBox.Show("Transaksi berhasil dilakukan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearTransaksi();
                    btrf.PerformClick();

                }
            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            btrf.PerformClick();
            new NotaTransaksi(Invoice).ShowDialog();
        }

        private void clearTransaksi()
        {
            cmbPelanggan.ResetText();
            cmbPaket.ResetText();
            cmbKurir.ResetText();
            cmbDibayar.ResetText();
            dtpBatasWaktu.Value = DateTime.Now;
            dtpTanggal.Value = DateTime.Now;
            txtJenis.Clear();
            txtQty.Text = "1";
            txtHarga.Text = "0";
            txtTotal.Text = "0";
            txtDiskon.Text = "0";
            txtPajak.Text = "0";
            txtNominalDiskon.Text = "0";
            txtNominalPajak.Text = "0";
            txtBiayaTambahan.Text = "0";
            txtTotalPembayaran.Text = "0";
            txtCatatan.Clear();
            dataGridView1.Rows.Clear();
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
            hitungTotalPembayaran();
        }

        private void txtPajak_TextChanged(object sender, EventArgs e)
        {
            hitungTotalPembayaran();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            hitungTotalPembayaran();
        }

        private void txtBiayaTambahan_TextChanged(object sender, EventArgs e)
        {
            hitungTotalPembayaran();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Total = Total + Convert.ToInt32(dataGridView1.Rows[i].Cells["harga"].Value);
            }

            hitungTotalPembayaran();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == hapus.Index)
            {
                string item = dataGridView1.Rows[e.RowIndex].Cells["nama_paket"].Value.ToString();
                var confirm = MessageBox.Show($"Apakah anda yakin ingin menghapus '{item}' dari keranjang?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                    Hitungkerangjang();
                }
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validasi.Angka(e);
        }

        private void txtDiskon_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validasi.Angka(e);
            Validasi.Batas_Persen(txtDiskon, 100, e);
        }

        private void txtPajak_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validasi.Angka(e);
            Validasi.Batas_Persen(txtPajak, 100, e);
        }

        private void txtBiayaTambahan_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validasi.Angka(e);
        }

        private void cmbPelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {
            btrf.PerformClick();
        }

        private void dtpBatasWaktu_Validating(object sender, CancelEventArgs e)
        {
            if (dtpBatasWaktu.Value < dtpTanggal.Value)
            {
                MessageBox.Show("Batas Waktu tidak boleh lebih kecil dari tanggal!");
            }
        }
    }
}
