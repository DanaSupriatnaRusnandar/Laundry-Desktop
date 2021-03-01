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
    public partial class UserControlKurir : UserControl
    {
        public UserControlKurir()
        {
            InitializeComponent();
        }
        string getIdKurir;
        string kurir;

        private void Tampilkan()
        {
            DataTable data = Db.Read("SELECT tb_kurir.id, tb_kurir.nama_kurir, tb_kurir.alamat, tb_kurir.tlp, tb_outlet.nama_outlet FROM tb_kurir INNER JOIN tb_outlet on tb_kurir.id_outlet = tb_outlet.id");
            dataGridViewKurir.Rows.Clear();
             foreach (DataRow row in data.Rows)
            {
                dataGridViewKurir.Rows.Add(row.Field<int>("id"), row.Field<string>("nama_kurir"), row.Field<string>("alamat"), row.Field<string>("tlp"), row.Field<string>("nama_outlet"));
            }
        }

        private void UserControlKurir_Load(object sender, EventArgs e)
        {

            dataGridViewKurir.BorderStyle = BorderStyle.None;
            dataGridViewKurir.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewKurir.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewKurir.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewKurir.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewKurir.BackgroundColor = Color.White;

            dataGridViewKurir.EnableHeadersVisualStyles = false;
            dataGridViewKurir.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewKurir.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewKurir.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //Biding Admin
            cmbOutlet.DataSource = Db.Read("tb_outlet", "id, nama_outlet");
            cmbOutlet.DisplayMember = "nama_outlet";
            cmbOutlet.ValueMember = "id";
            cmbOutlet.SelectedIndex = -1;

            Tampilkan();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            new TambahDataKurir(btn_refresh).ShowDialog();
        }

        private void cmbOutlet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOutlet.SelectedIndex >= 0)
            {
                kurir = cmbOutlet.SelectedValue.ToString();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Tampilkan();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin menghapus data user Ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_kurir", $"id = {getIdKurir}");
                Tampilkan();
                MessageBox.Show("Data kurir berhasil dihapus");
            }
        }

        private void dataGridViewKurir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewKurir.CurrentCell.RowIndex;
            getIdKurir = dataGridViewKurir.Rows[row].Cells["id"].Value.ToString();

        }
    }
}
