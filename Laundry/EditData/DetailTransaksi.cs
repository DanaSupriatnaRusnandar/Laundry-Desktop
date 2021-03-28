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
    public partial class DetailTransaksi : Form
    {
        string invoice;
        public DetailTransaksi(string kode_invoice)
        {
            InitializeComponent();
            invoice = kode_invoice;
        }

        private void DetailTransaksi_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            dataGridViewKeranjang.BorderStyle = BorderStyle.None;
            dataGridViewKeranjang.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewKeranjang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewKeranjang.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewKeranjang.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewKeranjang.BackgroundColor = Color.White;

            dataGridViewKeranjang.EnableHeadersVisualStyles = false;
            dataGridViewKeranjang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewKeranjang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewKeranjang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            DataTable data = Db.Read($"SELECT * FROM tb_transaksi JOIN tb_detail_transaksi ON tb_transaksi.id = tb_detail_transaksi.id_transaksi JOIN tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_paket ON tb_detail_transaksi.id_paket = tb_paket.id JOIN tb_kurir ON tb_transaksi.id_kurir = tb_kurir.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id JOIN tb_outlet ON tb_transaksi.id_outlet = tb_outlet.id WHERE tb_transaksi.kode_invoice = '{invoice}'");

            double pajak = 0;
            double diskon = 0;
            double biaya_tambahan = 0;
            double total = 0;
            int sum = 1;
            foreach (DataRow row in data.Rows)
            {
                lblInvoice.Text = invoice;
                lblTgl.Text = row.Field<DateTime>("tgl").ToString("dd/MM/yyyy HH:mm:ss");
                lblBatasWaktu.Text = row.Field<DateTime>("batas_waktu").ToString();
                lblTanggalBayar.Text = row.Field<DateTime?>("tgl_bayar").ToString();
                lblStatusCucian.Text = row.Field<string>("status");
                lblPembayaran.Text = row.Field<string>("dibayar");
                txtCatatan.Text = row.Field<string>("keterangan");
                txtNamaPelanggan.Text = row.Field<string>("nama_member");
                txtAlamatPelanggan.Text = row.Field<string>("alamat");
                txtJK.Text = row.Field<string>("jenis_kelamin"); 
                txtTlpPelanggan.Text = row.Field<string>("tlp");
                txtOutlet.Text = row.Field<string>("nama_outlet");
                txtTlpOutlet.Text = row.Field<string>("no_tlp");
                txtPetugas.Text = row.Field<string>("nama");
                txtKurir.Text = row.Field<string>("nama_kurir");
                txtCatatan.Text = row.Field<string>("keterangan");

                total = total + row.Field<int>("harga") * row.Field<double>("qty");
                pajak = row.Field<int>("pajak");
                diskon = row.Field<double>("diskon");
                biaya_tambahan = row.Field<int>("biaya_tambahan");

                dataGridViewKeranjang.Rows.Add(
                    row.Field<string>("nama_paket"),
                    row.Field<double>("qty"),
                   (row.Field<int>("harga") * row.Field<double>("qty")).ToString("C0")
               );
                if (sum < 6) sum++;

                int height = 25 * sum;
                dataGridViewKeranjang.Height = height;
                this.Height = this.Height + height - 50;

                lblPaket.Text = total.ToString("C0");
                lblPajak.Text = pajak.ToString("C0");
                lblbiayaTambahan.Text = biaya_tambahan.ToString("C0");
                lblDiskon.Text = diskon.ToString("C0");
                lblTotal.Text = (total + pajak + biaya_tambahan - diskon).ToString("C0");
            }
        }

        private void dataGridViewKeranjang_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var g = (DataGridView)sender;
            var r = new Rectangle(e.RowBounds.Left, e.RowBounds.Top,
                g.RowHeadersWidth, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, $"{e.RowIndex + 1}",
                g.RowHeadersDefaultCellStyle.Font, r, g.RowHeadersDefaultCellStyle.ForeColor);
        }

        private void dataGridViewKeranjang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var g = (DataGridView)sender;
            if (e.RowIndex > -1 && $"{g.Rows[e.RowIndex].HeaderCell.Value}" != $"{e.RowIndex + 1}")
            {
                g.Rows[e.RowIndex].HeaderCell.Value = $"{e.RowIndex + 1}";
            }
        }

        public class DataGridViewRowNumberColumn : DataGridViewColumn
        {
            public DataGridViewRowNumberColumn() : base()
            {
                this.CellTemplate = new DataGridViewRowNumberCell();
                this.Width = 40;
                this.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            [Browsable(false)]
            [DefaultValue(true)]
            public override bool ReadOnly
            {
                get { return true; }
                set { base.ReadOnly = true; }
            }
        }
        public class DataGridViewRowNumberCell : DataGridViewTextBoxCell
        {
            protected override void Paint(System.Drawing.Graphics graphics,
                System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds,
                int rowIndex, DataGridViewElementStates cellState, object value,
                object formattedValue, string errorText, DataGridViewCellStyle cellStyle,
                DataGridViewAdvancedBorderStyle advancedBorderStyle,
                DataGridViewPaintParts paintParts)
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value,
                    formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
            }
            protected override object GetValue(int rowIndex)
            {
                return rowIndex + 1;
            }
            protected override bool SetValue(int rowIndex, object value)
            {
                return base.SetValue(rowIndex, rowIndex + 1);
            }
        }
    }
}
