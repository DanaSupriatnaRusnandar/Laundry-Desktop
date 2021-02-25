using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry
{
    public partial class UserControlOutlet : UserControl
    {
        public UserControlOutlet()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            TambahDataOutlet outlet = new TambahDataOutlet();
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
    }
}
