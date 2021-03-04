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
    public partial class UserControlTransaksi : UserControl
    {
        public UserControlTransaksi()
        {
            InitializeComponent();
        }

        public void Tampilkan()
        {
            DataTable data = Db.Read("tb_outlet", "*");
            dataGridViewTransaksi.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                dataGridViewTransaksi.Rows.Add($"NULL", $"NULL", row.Field<string>("kode_invoice"), $"NULL" ,row.Field<string>("alamat"), row.Field<string>("tlp"));
            }
        }

        private void UserControlTransaksi_Load(object sender, EventArgs e)
        {
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
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            new Transaksi(btn_refresh).ShowDialog();
        }
    }
}
