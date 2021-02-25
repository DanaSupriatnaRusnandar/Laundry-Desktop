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
    public partial class UserControlDataOwner : UserControl
    {
        public UserControlDataOwner()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            TambahDataOwner owner = new TambahDataOwner();
            owner.Show();
        }

        private void UserControlDataOwner_Load(object sender, EventArgs e)
        {
            dataGridViewOwner.BorderStyle = BorderStyle.None;
            dataGridViewOwner.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewOwner.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewOwner.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewOwner.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewOwner.BackgroundColor = Color.White;

            dataGridViewOwner.EnableHeadersVisualStyles = false;
            dataGridViewOwner.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewOwner.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewOwner.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
