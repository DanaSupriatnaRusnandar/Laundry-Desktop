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
    public partial class UserControlDataKasir : UserControl
    {
        public UserControlDataKasir()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            TambahDataKasir kasir = new TambahDataKasir();
            kasir.Show();
        }

        private void UserControlDataKasir_Load(object sender, EventArgs e)
        {
            dataGridViewKasir.BorderStyle = BorderStyle.None;
            dataGridViewKasir.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewKasir.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewKasir.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewKasir.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewKasir.BackgroundColor = Color.White;

            dataGridViewKasir.EnableHeadersVisualStyles = false;
            dataGridViewKasir.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewKasir.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewKasir.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
