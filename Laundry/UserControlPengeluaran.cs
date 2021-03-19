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
using ClosedXML.Excel;

namespace Laundry
{
    public partial class UserControlPengeluaran : UserControl
    {
        string getIdPengeluaran;
        int Total;
        public UserControlPengeluaran()
        {
            InitializeComponent();
        }

        private void UserControlPengeluaran_Load(object sender, EventArgs e)
        {
            dataGridViewPengeluaran.BorderStyle = BorderStyle.None;
            dataGridViewPengeluaran.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewPengeluaran.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewPengeluaran.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewPengeluaran.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewPengeluaran.BackgroundColor = Color.White;

            dataGridViewPengeluaran.EnableHeadersVisualStyles = false;
            dataGridViewPengeluaran.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewPengeluaran.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewPengeluaran.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            Tampilkan();
        }

        private void Tampilkan()
        {
            if (Session.getUserLogged().Rows[0].Field<string>("role") == "superAdmin")
            {
                DataTable data = Db.Read($"SELECT * FROM tb_pengeluaran join tb_outlet on tb_pengeluaran.id_outlet = tb_outlet.id");
                dataGridViewPengeluaran.AutoGenerateColumns = false;
                dataGridViewPengeluaran.DataSource = data;
            }
            else
            {
                DataTable data = Db.Read($"SELECT * FROM tb_pengeluaran join tb_outlet on tb_pengeluaran.id_outlet = tb_outlet.id WHERE tb_pengeluaran.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")}");
                dataGridViewPengeluaran.AutoGenerateColumns = false;
                dataGridViewPengeluaran.DataSource = data;
            }
            hitungPengeluaran();

        }

        private void CariData(string keyword)
        {
            if(Session.getUserLogged().Rows[0].Field<string>("role") == "superAdmin")
            {
                dataGridViewPengeluaran.AutoGenerateColumns = false;
                dataGridViewPengeluaran.DataSource = Db.Read($"SELECT * FROM tb_pengeluaran join tb_outlet on tb_pengeluaran.id_outlet = tb_outlet.id WHERE tb_outlet.nama_outlet LIKE '%{keyword}%' OR tb_pengeluaran.nama_barang LIKE '%{keyword}%' OR tb_pengeluaran.tgl LIKE '%{keyword}%'");
            }
            else if (Session.getUserLogged().Rows[0].Field<string>("role") != "superAdmin")
            {
                dataGridViewPengeluaran.AutoGenerateColumns = false;
                dataGridViewPengeluaran.DataSource = Db.Read($"SELECT * FROM tb_pengeluaran join tb_outlet on tb_pengeluaran.id_outlet = tb_outlet.id WHERE tb_pengeluaran.id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")} AND tb_pengeluaran.nama_barang LIKE '%{keyword}%' OR tb_pengeluaran.tgl LIKE '%{keyword}%' ");
            }
            hitungPengeluaran();
        }

        private void hitungPengeluaran()
        {
            //Jumlah pengeluaran
            double pengeluaran = 0;
            foreach (DataGridViewRow row in dataGridViewPengeluaran.Rows)
            {
                pengeluaran = pengeluaran + Convert.ToDouble(row.Cells["total"].Value);
            }
            txtTotal.Text = pengeluaran.ToString("C0");
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Tampilkan();
            txtCari.Clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin menghapus data pengeluarana Ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_pengeluaran", $"id = {getIdPengeluaran}");
                Tampilkan();
                MessageBox.Show("Data pengeluaran berhasil dihapus!");

            }
        }

        private void dataGridViewPengeluaran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewPengeluaran.CurrentCell.RowIndex;
            getIdPengeluaran = dataGridViewPengeluaran.Rows[row].Cells["id"].Value.ToString();
        }

        private void dataGridViewPengeluaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewPengeluaran.Columns["edit"].Index)
            {
                var row = dataGridViewPengeluaran.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                string id_outlet = row.Cells["id_outlet"].Value.ToString();
                string outlet = row.Cells["nama_outlet"].Value.ToString();
                string nama = row.Cells["nama_barang"].Value.ToString();
                DateTime tgl = (DateTime)row.Cells["tgl"].Value;
                string total = row.Cells["total"].Value.ToString();
                string keterangan = row.Cells["keterangan"].Value.ToString();
                new EditDataPengeluaran(btn_refresh, id,id_outlet, outlet, nama, tgl, total, keterangan).ShowDialog();
            }
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            //EXPORT TO EXCEL
            saveFileDialog.InitialDirectory = "C";
            saveFileDialog.Title = "SIMPAN FILE EXCEL";
            saveFileDialog.FileName = "";
            saveFileDialog.Filter = "Excel Files (Excel)|*.xlsx";

            if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                //Change Properties
                Cursor.Current = Cursors.WaitCursor;
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);

                excelApp.Columns.ColumnWidth = 28;
                for (int i = 1; i < dataGridViewPengeluaran.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dataGridViewPengeluaran.Columns[i - 1].HeaderText;
                }
                for (int i = 1; i < dataGridViewPengeluaran.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewPengeluaran.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dataGridViewPengeluaran.Rows[1].Cells[j].Value.ToString();
                    }
                }
                excelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog.FileName.ToString());
                excelApp.ActiveWorkbook.Saved = false;
                excelApp.Quit();

                MessageBox.Show("Export berhasil");
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            new TambahDataPengeluaran(btn_refresh, getIdPengeluaran).ShowDialog();
        }

        //Cari Data
        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (txtCari.Text.Length > 0)
                CariData(txtCari.Text);
        }
    }
}
