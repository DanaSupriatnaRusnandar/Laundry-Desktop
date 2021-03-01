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
        string getIdOutlet;

        public void Tampilkan()
        {
            DataTable data = Db.Read("tb_outlet", "*");
            dataGridViewOtlet.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                dataGridViewOtlet.Rows.Add(row.Field<int>("id"), row.Field<string>("nama_outlet"), row.Field<string>("alamat"), row.Field<string>("tlp"));
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            new TambahDataOutlet(btn_refresh).ShowDialog();
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

            Tampilkan();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Tampilkan();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin menghapus data outlet Ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_outlet", $"id = {getIdOutlet}");
                Tampilkan();
                MessageBox.Show("Data outlet berhasil dihapus!");

            }
        }

        private void dataGridViewOtlet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewOtlet.CurrentCell.RowIndex;
            getIdOutlet = dataGridViewOtlet.Rows[row].Cells["id"].Value.ToString();
        }
    }
}
