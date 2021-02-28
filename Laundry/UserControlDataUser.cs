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
    public partial class UserControlDataUser : UserControl
    {
        string user;
        public UserControlDataUser()
        {
            InitializeComponent();
        }
        string getIdUser;

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

            /*//Biding Admin
            cmbAdmin.DataSource = Db.Read("tb_user", "id, id_role");
            cmbAdmin.DisplayMember = "id_role";
            cmbAdmin.ValueMember = "id";
            cmbAdmin.SelectedIndex = -1;*/


            Tampilkan();
        }

        private void Tampilkan()
        {
            DataTable data = Db.Read("SELECT tb_user.id, tb_user.nama, tb_user.username, tb_user.password, tb_outlet.nama_outlet, tb_user.role FROM tb_user INNER JOIN tb_outlet on tb_user.id_outlet = tb_outlet.id");
            dataGridViewAdmin.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                dataGridViewAdmin.Rows.Add($"NULL",row.Field<string>("nama"), row.Field<string>("username"), row.Field<string>("password"), row.Field<string>("nama_outlet") , row.Field<string>("role"));
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            new TambahDataUser(btn_refresh).ShowDialog();
        }

        private void cmbAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAdmin.SelectedIndex >= 0)
                {
                user = cmbAdmin.SelectedValue.ToString();
                }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Tampilkan();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin Menghapus Data Ini?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_jenis", $"id = {getIdUser}");
                Tampilkan();
                MessageBox.Show("Data Telah Dihapus!");

            }
        }

        private void dataGridViewAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewAdmin.CurrentCell.RowIndex;
            getIdUser = dataGridViewAdmin.Rows[row].Cells["id"].Value.ToString();
        }
    }
}
