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
    public partial class UserControlPelanggancs : UserControl
    {
        public UserControlPelanggancs()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            RegistrasiPelanggan reg = new RegistrasiPelanggan(this, btn_refresh);
            reg.Show();
        }

        private void UserControlPelanggancs_Load(object sender, EventArgs e)
        {
            dataGridViewRegistrasi.BorderStyle = BorderStyle.None;
            dataGridViewRegistrasi.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewRegistrasi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewRegistrasi.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewRegistrasi.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewRegistrasi.BackgroundColor = Color.White;

            dataGridViewRegistrasi.EnableHeadersVisualStyles = false;
            dataGridViewRegistrasi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewRegistrasi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewRegistrasi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            Tampilkan();
        }

        private void Tampilkan()
        {
            DataTable data = Db.Read("tb_member", "*");
            dataGridViewRegistrasi.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                dataGridViewRegistrasi.Rows.Add($"NULL", row.Field<string>("nama"), row.Field<string>("alamat"), row.Field<string>("jenis_kelamin"), row.Field<string>("tlp"));
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Tampilkan();
        }
    }
}
