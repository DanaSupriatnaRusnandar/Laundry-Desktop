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
    public partial class UserControlOutlet : UserControl
    {
        public UserControlOutlet()
        {
            InitializeComponent();
        }

        public void Tampilkan()
        {
            DataTable data = Db.Read("tb_outlet", "*");
            dataGridViewOtlet.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                dataGridViewOtlet.Rows.Add($"NULL",row.Field<string>("nama"), row.Field<string>("alamat"), row.Field<string>("tlp"));
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            TambahDataOutlet outlet = new TambahDataOutlet(this, btn_refresh);
            outlet.Show();
        }

        private void UserControlOutlet_Load(object sender, EventArgs e)
        {
            dataGridViewOtlet.BorderStyle = BorderStyle.None;
            dataGridViewOtlet.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewOtlet.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewOtlet.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewOtlet.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewOtlet.BackgroundColor = Color.White;

            dataGridViewOtlet.EnableHeadersVisualStyles = false;
            dataGridViewOtlet.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewOtlet.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewOtlet.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Tampilkan();
        }
    }
}
