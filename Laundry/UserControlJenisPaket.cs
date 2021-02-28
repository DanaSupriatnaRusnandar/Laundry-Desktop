﻿using System;
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
    public partial class UserControlJenisPaket : UserControl
    {
        public UserControlJenisPaket()
        {
            InitializeComponent();
        }

        public string getIdJenis;

        private void Tampilkan()
        {
            DataTable data = Db.Read("tb_jenis", "*");
            dataGridViewJenis.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                dataGridViewJenis.Rows.Add($"NULL", row.Field<string>("jenis"));
            }
        }

        private void UserControlJenisPaket_Load(object sender, EventArgs e)
        {
            dataGridViewJenis.BorderStyle = BorderStyle.None;
            dataGridViewJenis.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewJenis.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewJenis.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewJenis.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewJenis.BackgroundColor = Color.White;

            dataGridViewJenis.EnableHeadersVisualStyles = false;
            dataGridViewJenis.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewJenis.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewJenis.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            Tampilkan();
        }

        private bool isfilled()
        {
            if (txtCari.Text.Length > 0) return false;
            return true;
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                var jenis = txtAdd.Text;

                if(  Db.Insert("tb_jenis", $"NULL, '{jenis}'"))
                {
                    MessageBox.Show("Jenis barang berhasil di tambahkan");
                    txtAdd.Clear();
                }
                else
                {
                    MessageBox.Show($"Gagal menambah jenis barang \n\n ERROR MESSAGE : \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Tampilkan();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
          /*  var confirm = MessageBox.Show("Yakin inngin menghapus data jenis paket ini?", "Konfirmasie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_jenis", $"id = {getIdJenis}");
                Tampilkan();
                MessageBox.Show("Data telah dihapus");
            }*/

            var confirm = MessageBox.Show("Apakah anda yakin ingin Menghapus Data Ini?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_jenis", $"id = {getIdJenis}");
                Tampilkan();
                MessageBox.Show("Data Telah Dihapus!");

            }
        }

        private void dataGridViewJenis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewJenis.CurrentCell.RowIndex;
            getIdJenis = dataGridViewJenis.Rows[row].Cells["id"].Value.ToString();
        }
    }
}
