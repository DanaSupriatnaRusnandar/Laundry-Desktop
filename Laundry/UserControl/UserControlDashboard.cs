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
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Color = System.Drawing.Color;
using Point = System.Windows.Point;

namespace Laundry
{
    public partial class UserControlDashboard : UserControl
    {
        DateTime lastDayOfMonth;
        DateTime firstDayOfMonth;
        int id_outlet;
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

            firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            lastDayOfMonth = firstDayOfMonth.AddMonths(1);
            //.AddDays(-1)

            id_outlet = Session.getUserLogged().Rows[0].Field<int>("id_outlet");

            Tampilkan();
        }

        public void Tampilkan()
        {
            DataTable data = Db.Read($"SELECT DATE(tb_transaksi.tgl_bayar) AS tgl_bayar, SUM(tb_transaksi.total_pembayaran) AS total_tagihan FROM tb_transaksi WHERE id_outlet = '{id_outlet}' AND dibayar = 'dibayar' AND tgl_bayar BETWEEN '{firstDayOfMonth.ToString("yyyy/MM/dd")}' AND '{lastDayOfMonth.ToString("yyyy/MM/dd")}' GROUP BY DATE(tb_transaksi.tgl_bayar)");
            DataTable data2 = Db.Read($"SELECT DATE(tb_pengeluaran.tgl) AS tanggal, SUM(tb_pengeluaran.harga) AS jumlah FROM tb_pengeluaran WHERE id_outlet = '{id_outlet}' AND tb_pengeluaran.tgl BETWEEN '{firstDayOfMonth.ToString("yyyy/MM/dd")}' AND '{lastDayOfMonth.ToString("yyyy/MM/dd")}' GROUP BY DATE(tb_pengeluaran.tgl)");
            fillChart(data, data2);
            MessageBox.Show(data.Rows.Count.ToString());
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

        //Live Chart
        private void fillChart(DataTable source, DataTable source2)
        {
            chartTransaksi.Series.Clear();
            chartTransaksi.AxisX.Clear();
            chartTransaksi.AxisY.Clear();
            if (source.Rows.Count > 1) setChart(chartTransaksi, source, source2);
        }

        private void setChart(LiveCharts.WinForms.CartesianChart chart, DataTable data, DataTable data2)
        {
            var gradientBrush = new LinearGradientBrush
            {
                StartPoint = new System.Windows.Point(0, 0),
                EndPoint = new Point(0, 1)
            };
            gradientBrush.GradientStops.Add(new GradientStop(System.Windows.Media.Color.FromRgb(7, 173, 10), 0));
            gradientBrush.GradientStops.Add(new GradientStop(Colors.Transparent, 1));

            var gradientBrush2 = new LinearGradientBrush
            {
                StartPoint = new System.Windows.Point(0, 0),
                EndPoint = new Point(0, 1)
            };
            gradientBrush2.GradientStops.Add(new GradientStop(System.Windows.Media.Color.FromRgb(241, 48, 48), 0));
            gradientBrush2.GradientStops.Add(new GradientStop(Colors.Transparent, 1));

            chart.Series.Add(new LineSeries
            {
                Title = "Pemasukan",
                Values = GetData(data),
                Fill = gradientBrush,
                StrokeThickness = 1,
                PointGeometry = null
            });

            chart.Series.Add(new LineSeries
            {
                Title = "Pengeluaran",
                Values = GetData2(data2),
                Fill = gradientBrush2,
                StrokeThickness = 1,
                PointGeometry = null
            });


            chart.Zoom = ZoomingOptions.X;

            chart.AxisX.Add(new Axis
            {
                LabelFormatter = val => new System.DateTime((long)val).ToString("dd MMMM yyyy")
            });

            chart.AxisY.Add(new Axis
            {
                LabelFormatter = val => val.ToString("C")
            });
        }

        private ChartValues<DateTimePoint> GetData(DataTable data)
        {
            var values = new ChartValues<DateTimePoint>();
            List<DateTime> tgl = new List<DateTime>();
            List<decimal> jml = new List<decimal>();
            foreach (DataRow row in data.Rows)
            {
                tgl.Add(row.Field<DateTime>("tgl_bayar"));
                jml.Add(row.Field<decimal>("total_tagihan"));
            }

            int i = 0;
            int totalDays = Convert.ToInt32((firstDayOfMonth.Date - lastDayOfMonth.Date).TotalDays * -1);
            for (int t = 0; t <= totalDays; t++)
            {
                DateTime tanggal = firstDayOfMonth.AddDays(t);
                if (tgl.Contains(tanggal))
                {
                    decimal jumlah = jml[i];
                    values.Add(new DateTimePoint(tanggal.ToLocalTime(), Convert.ToDouble(jumlah)));
                    i++;
                }
                else
                    values.Add(new DateTimePoint(firstDayOfMonth.AddDays(t).ToLocalTime(), 0));
            }


            return values;
        }

        private ChartValues<DateTimePoint> GetData2(DataTable data)
        {
            var values = new ChartValues<DateTimePoint>();
            List<DateTime> tgl = new List<DateTime>();
            List<decimal> jml = new List<decimal>();
            foreach (DataRow row in data.Rows)
            {
                tgl.Add(row.Field<DateTime>("tanggal"));
                jml.Add(row.Field<decimal>("jumlah"));
            }

            int i = 0;
            int totalDays = Convert.ToInt32((firstDayOfMonth.Date - lastDayOfMonth.Date).TotalDays * -1);
            for (int t = 0; t <= totalDays; t++)
            {
                DateTime tanggal = firstDayOfMonth.AddDays(t);
                if (tgl.Contains(tanggal))
                {
                    decimal jumlah = jml[i];
                    values.Add(new DateTimePoint(tanggal.ToLocalTime(), Convert.ToDouble(jumlah)));
                    i++;
                }
                else
                    values.Add(new DateTimePoint(firstDayOfMonth.AddDays(t).ToLocalTime(), 0));
            }

            return values;
        }
    }
}