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
    public partial class UserControlPaketLaundry : UserControl
    {
        string Outlet;
        public UserControlPaketLaundry()
        {
            InitializeComponent();
        }

        private void UserControlPaketLaundry_Load(object sender, EventArgs e)
        {
            dataGridViewpaket.BorderStyle = BorderStyle.None;
            dataGridViewpaket.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewpaket.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewpaket.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewpaket.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewpaket.BackgroundColor = Color.White;

            dataGridViewpaket.EnableHeadersVisualStyles = false;
            dataGridViewpaket.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewpaket.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewpaket.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // binding outlet(combobox)
            cmbOutlet.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
            cmbOutlet.DisplayMember = "nama";
            cmbOutlet.ValueMember = "id";
            cmbOutlet.SelectedIndex = -1;

            Tampilkan();
        }

        private void Tampilkan()
        {
            dataGridViewpaket.AutoGenerateColumns = false;
            dataGridViewpaket.DataSource = Db.Read("SELECT tb_paket.id, tb_outlet.nama_outlet ,tb_paket.nama_paket, tb_jenis.jenis, tb_paket.harga FROM tb_paket INNER JOIN tb_outlet on tb_paket.id_outlet = tb_outlet.id INNER JOIN tb_jenis ON tb_paket.id_jenis = tb_jenis.id");

            // dataGridViewpaket.DataSource = Db.Read("tb_paket", "*");

            /* DataTable data = Db.Read("SELECT tb_paket.id, tb_outlet.nama_outlet ,tb_paket.nama_paket, tb_jenis.jenis, tb_paket.harga FROM tb_paket INNER JOIN tb_outlet on tb_paket.id_outlet = tb_outlet.id INNER JOIN tb_jenis ON tb_paket.id_jenis = tb_jenis.id");
             dataGridViewpaket.Rows.Clear();
             foreach (DataRow row in data.Rows)
             {
                 dataGridViewpaket.Rows.Add($"NULL", row.Field<string>("nama_outlet"), row.Field<string>("nama_paket"), row.Field<string>("jenis"), row.Field<string>("harga"));
             }*/
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            PaketLaundry paket = new PaketLaundry(this, btn_refresh, Outlet);
            paket.Show();
        }

        private void cmbOutlet_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (cmbOutlet.SelectedIndex >= 0)
            {
                Outlet = cmbOutlet.SelectedValue.ToString();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Tampilkan();
        }
    }
}
