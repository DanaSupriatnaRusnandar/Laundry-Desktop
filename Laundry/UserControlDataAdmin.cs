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
    public partial class UserControlDataAdmin : UserControl
    {
        string user;
        public UserControlDataAdmin()
        {
            InitializeComponent();
        }

        private void UserControlDataAdmin_Load(object sender, EventArgs e)
        {
            dataGridViewAdmin.BorderStyle = BorderStyle.None;
            dataGridViewAdmin.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewAdmin.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewAdmin.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewAdmin.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewAdmin.BackgroundColor = Color.White;

            dataGridViewAdmin.EnableHeadersVisualStyles = false;
            dataGridViewAdmin.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewAdmin.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewAdmin.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //Biding Admin
            cmbAdmin.DataSource = Db.Read("tb_user", "id, role");
            cmbAdmin.DisplayMember = "role";
            cmbAdmin.ValueMember = "id";
            cmbAdmin.SelectedIndex = -1;
        }

        private void Tampilkan()
        {
            DataTable data = Db.Read("tb_user", "*");
            dataGridViewAdmin.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                dataGridViewAdmin.Rows.Add($"NULL",row.Field<string>("nama"), row.Field<string>("username"), row.Field<string>("password"), $"NULL", row.Field<string>("role"));
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Form admin = new TambahDataAdmin(this, btn_refresh);
            admin.ShowDialog();
        }

        private void cmbAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    user = cmbAdmin.SelectedValue.ToString();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Tampilkan();
        }
    }
}
