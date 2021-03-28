using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Luthor.lib;

namespace Laundry
{
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            //Jam & Tanggal
            lblJam.Text = DateTime.Now.ToLongTimeString();
            lblHariTanggal.Text = DateTime.Now.ToLongDateString();
            timer.Enabled = true;

            lblRole.Text = Session.getUserLogged().Rows[0].Field<string>("nama");

            //Laundry
            if (Session.getUserLogged().Rows[0].Field<string>("role") == "admin")
            {
                lblPelanggan.Text = Db.Read($"SELECT COUNT(*) AS total FROM tb_member").Rows[0].Field<Int64>("total").ToString();
                lblTransaksi.Text = Db.Read($"SELECT COUNT(*)AS total FROM tb_transaksi").Rows[0].Field<Int64>("total").ToString();
                lblBaru.Text = Db.Read($"SELECT COUNT(*)AS total FROM tb_transaksi WHERE status = 'baru'").Rows[0].Field<Int64>("total").ToString();
                lblProses.Text = Db.Read($"SELECT COUNT(*)AS total FROM tb_transaksi WHERE status = 'proses'").Rows[0].Field<Int64>("total").ToString();
                lblSelesai.Text = Db.Read($"SELECT COUNT(*)AS total FROM tb_transaksi WHERE status = 'selesai'").Rows[0].Field<Int64>("total").ToString();
                lblAmbil.Text = Db.Read($"SELECT COUNT(*)AS total FROM tb_transaksi WHERE status = 'diambil'").Rows[0].Field<Int64>("total").ToString();
            }
            else if (Session.getUserLogged().Rows[0].Field<string>("role") != "admin")
            {
                lblPelanggan.Text = Db.Read($"SELECT COUNT(*) AS total FROM tb_member WHERE tb_member.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")}").Rows[0].Field<Int64>("total").ToString();
                lblTransaksi.Text = Db.Read($"SELECT COUNT(*)AS total FROM tb_transaksi WHERE tb_transaksi.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")}").Rows[0].Field<Int64>("total").ToString();
                lblBaru.Text = Db.Read($"SELECT COUNT(*)AS total FROM tb_transaksi WHERE status = 'baru' AND tb_transaksi.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")}").Rows[0].Field<Int64>("total").ToString();
                lblProses.Text = Db.Read($"SELECT COUNT(*)AS total FROM tb_transaksi WHERE status = 'proses' AND tb_transaksi.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")}").Rows[0].Field<Int64>("total").ToString();
                lblSelesai.Text = Db.Read($"SELECT COUNT(*)AS total FROM tb_transaksi WHERE status = 'selesai' AND tb_transaksi.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")}").Rows[0].Field<Int64>("total").ToString();
                lblAmbil.Text = Db.Read($"SELECT COUNT(*)AS total FROM tb_transaksi WHERE status = 'diambil' AND tb_transaksi.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")}").Rows[0].Field<Int64>("total").ToString();
            }

            dataGridViewTransaksi.BorderStyle = BorderStyle.None;
            dataGridViewTransaksi.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewTransaksi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewTransaksi.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewTransaksi.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewTransaksi.BackgroundColor = Color.White;

            dataGridViewTransaksi.EnableHeadersVisualStyles = false;
            dataGridViewTransaksi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewTransaksi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewTransaksi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            Tampilkan();
        }

        public void Tampilkan()
        {
            if (Session.getUserLogged().Rows[0].Field<string>("role") == "admin")
            {
                DataTable data = Db.Read($"SELECT * FROM tb_transaksi join tb_outlet on tb_transaksi.id_outlet = tb_outlet.id JOIN tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_kurir ON tb_transaksi.id_kurir = tb_kurir.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id JOIN tb_detail_transaksi ON tb_detail_transaksi.id_transaksi = tb_transaksi.id JOIN tb_paket ON tb_detail_transaksi.id_paket = tb_paket.id ORDER BY tb_transaksi.id DESC LIMIT 9");
                dataGridViewTransaksi.AutoGenerateColumns = false;
                dataGridViewTransaksi.DataSource = data;
            }
            else if (Session.getUserLogged().Rows[0].Field<string>("role") != "admin")
            {
                DataTable data = Db.Read($"SELECT * FROM tb_transaksi join tb_outlet on tb_transaksi.id_outlet = tb_outlet.id JOIN tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_kurir ON tb_transaksi.id_kurir = tb_kurir.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id JOIN tb_detail_transaksi ON tb_detail_transaksi.id_transaksi = tb_transaksi.id JOIN tb_paket ON tb_detail_transaksi.id_paket = tb_paket.id WHERE tb_transaksi.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")} ORDER BY tb_transaksi.id DESC LIMIT 9");
                dataGridViewTransaksi.AutoGenerateColumns = false;
                dataGridViewTransaksi.DataSource = data;
            }
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            lblJam.Text = DateTime.Now.ToLongTimeString();
            lblHariTanggal.Text = DateTime.Now.ToLongDateString();
        }

        private void dataGridViewTransaksi_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var g = (DataGridView)sender;
            var r = new Rectangle(e.RowBounds.Left, e.RowBounds.Top,
                g.RowHeadersWidth, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, $"{e.RowIndex + 1}",
                g.RowHeadersDefaultCellStyle.Font, r, g.RowHeadersDefaultCellStyle.ForeColor);
        }

        private void dataGridViewTransaksi_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}