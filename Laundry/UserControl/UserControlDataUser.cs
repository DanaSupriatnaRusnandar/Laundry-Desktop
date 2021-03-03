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
     //   string user;
        string getIdUser;
        public UserControlDataUser()
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

           // colPaket.Width = (int)(dataGridViewAdmin.Width * 0.50);

            dataGridViewAdmin.EnableHeadersVisualStyles = false;
            dataGridViewAdmin.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewAdmin.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewAdmin.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            Tampilkan();
        }

        //Function
        private void Tampilkan()
        {
            DataTable data = Db.Read("SELECT * FROM tb_user JOIN tb_outlet ON tb_user.id_outlet = tb_outlet.id JOIN tb_role ON tb_user.id_role = tb_role.id");
            dataGridViewAdmin.AutoGenerateColumns = false;
            dataGridViewAdmin.DataSource = data;
       
        }

        private void CariData(string keyword)
        {
            dataGridViewAdmin.AutoGenerateColumns = false;
            dataGridViewAdmin.DataSource = Db.Read($"SELECT * FROM tb_user JOIN tb_outlet ON tb_user.id_outlet = tb_outlet.id JOIN tb_role ON tb_user.id_role = tb_role.id WHERE tb_user.nama LIKE '%{keyword}%' OR tb_user.username LIKE '%{keyword}%' OR tb_outlet.nama_outlet LIKE '%{keyword}%' OR tb_role.nama_role LIKE '%{keyword}%'");
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            new TambahDataUser(btn_refresh, getIdUser).ShowDialog();
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
                Db.Delete("tb_user", $"id = {getIdUser}");
                Tampilkan();
                MessageBox.Show("Data user berhasil dihapus!");

            }
        }

        private void dataGridViewAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewAdmin.CurrentCell.RowIndex;
            getIdUser = dataGridViewAdmin.Rows[row].Cells["id"].Value.ToString();

            
        }

        private void dataGridViewAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edit
            if (e.ColumnIndex == dataGridViewAdmin.Columns["edit"].Index)
            {
                var row = dataGridViewAdmin.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                string nama = row.Cells["nama"].Value.ToString();
                string username = row.Cells["username"].Value.ToString();
                string password = row.Cells["password"].Value.ToString();
                string id_outlet = row.Cells["id_outlet"].Value.ToString();
                string outlet = row.Cells["nama_outlet"].Value.ToString();
                string nama_role = row.Cells["nama_role"].Value.ToString();
                new EditDataUser(btn_refresh, id, nama, username, password, id_outlet, outlet, nama_role).ShowDialog();
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            CariData(txtCari.Text);
        }
    }
}
