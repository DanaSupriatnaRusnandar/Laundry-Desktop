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
    public partial class TambahTransaksi : Form
    {
        Button btrf;
        string getIdTransaksi;
        string getIdPaket;
        int Total;
        int petugas;
        public TambahTransaksi(Button btrefresh, string id)
        {
            InitializeComponent();
            btrf = btrefresh;
            getIdTransaksi = id;
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            //Biding Outlet
            /*cmbOutlet.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
            cmbOutlet.DisplayMember = "nama_outlet";
            cmbOutlet.ValueMember = "id";
            cmbOutlet.SelectedIndex = -1;*/

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
            if (cmbPelanggan.SelectedIndex >= 0 && dtpTanggal.Checked && dtpBatasWaktu.Checked && txtDiskon.Text.Length >= 0 && txtBiayaTambahan.Text.Length >= 0 && txtPajak.Text.Length >= 0 && cmbDibayar.SelectedIndex >= 0 && dtpTanggalBayar.Checked && txtCatatan.Text.Length >= 0 && cmbKurir.SelectedIndex >= 0) return true;
            return false;
        }

        void Dibayar(object selectedItem)
        {
            cmbDibayar.Items.Add("dibayar");
            cmbDibayar.Items.Add("belum_dibayar");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new RegistrasiPelanggan(btn_refresh).ShowDialog();
        }

        private void ClearData()
        {
            cmbPaket.SelectedIndex = -1;
            txtJenis.Clear();
            txtQty.Text = "1";
            txtHarga.Clear();
            txtTotal.Clear();
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
                var outlet = Session.getUserLogged().Rows[0].Field<int>("id");
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
                    var total_pembayaran = dataGridView1.Rows[i].Cells["harga"].Value.ToString();

                    getIdPaket = dataGridView1.Rows[i].Cells["id"].Value.ToString();
                    if (Db.Insert($"tb_transaksi", $"Null, '{outlet}', '{invoice}', '{pelanggan}', '{tanggal}', '{batasWaktu}', '{tanggalBayar}', '{biayaTambahan}', '{diskon}', '{pajak}', '{total_pembayaran}', 'baru', '{dibayar}', '{kurir}', '{petugas}'"))
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
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtDiskon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtPajak_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtBiayaTambahan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
