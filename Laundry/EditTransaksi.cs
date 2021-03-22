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
        string kode_invoice;
        public EditTransaksi(Button btrefresh, string invoice)
        {
            InitializeComponent();
            btrf = btrefresh;
            kode_invoice = invoice;
        }

        private void EditTransaksi_Load(object sender, EventArgs e)
        {
            

            Dibayar();
            Status();

            //data
            DataTable data = Db.Read($"SELECT * FROM tb_detail_transaksi JOIN tb_transaksi ON tb_detail_transaksi.id_transaksi = tb_transaksi.id JOIN tb_paket ON tb_detail_transaksi.id_paket = tb_paket.id WHERE kode_invoice = '{kode_invoice}'");
            foreach (DataRow row in data.Rows)
            {
                cmbStatus.SelectedIndex = cmbStatus.FindStringExact(row.Field<string>("status"));
                cmbDibayar.SelectedIndex = cmbDibayar.FindStringExact(row.Field<string>("dibayar"));
            }
        }
        
        void Dibayar()
        {
            cmbDibayar.Items.Add("dibayar");
            cmbDibayar.Items.Add("belum_dibayar");
        }
        void Status()
        {
            cmbStatus.Items.Add("baru");
            cmbStatus.Items.Add("Proses");
            cmbStatus.Items.Add("selesai");
            cmbStatus.Items.Add("diambil");
        }
        private bool isfilled()
        {
            if (cmbStatus.SelectedIndex >= 0 && cmbDibayar.SelectedIndex >= 0) return true;
            return false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                var dibayar = cmbDibayar.SelectedItem;
                var status = cmbStatus.SelectedItem;
                string tanggalBayar = "Null";
                if (cmbDibayar.SelectedIndex == 0) tanggalBayar = $"'{now}'";

                if (Db.Update("tb_transaksi", $"dibayar = '{dibayar}', status = '{status}', tgl_bayar = {tanggalBayar}", $"kode_invoice = '{kode_invoice}'"))
                {
                    MessageBox.Show("Data berhasil diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    btrf.PerformClick();
                }
                else
                {
                    MessageBox.Show($"ERROR : {Error.error_msg}");
                }


            }
        }
    }
}
