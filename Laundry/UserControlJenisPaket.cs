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
    public partial class UserControlJenisPaket : UserControl
    {
        public UserControlJenisPaket()
        {
            InitializeComponent();
        }
        public string getIdJenis;

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

        private void Tampilkan()
        {
            dataGridViewJenis.AutoGenerateColumns = false;
            dataGridViewJenis.DataSource = Db.Read("tb_jenis", "*");

            /*DataTable data = Db.Read("tb_jenis", "*");
            dataGridViewJenis.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                dataGridViewJenis.Rows.Add(row.Field<int>("id"), row.Field<string>("jenis"));
            }*/
        }

        private void CariData(string keyword)
        {
            dataGridViewJenis.AutoGenerateColumns = false;
            dataGridViewJenis.DataSource = Db.Read($"SELECT * FROM tb_jenis WHERE tb_jenis.jenis LIKE '%{keyword}%'");
        }

        private bool isfilled()
        {
            if (txtCari.Text.Length > 0) return false;
            return true;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Tampilkan();
            txtCari.Clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
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

        private void dataGridViewJenis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewJenis.Columns["edit"].Index)
            {
                var row = dataGridViewJenis.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                string jenis = row.Cells["jenis"].Value.ToString();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (isfilled())
            {
                var jenis = txtAdd.Text;

                if (Db.Insert("tb_jenis", $"NULL, '{jenis}'"))
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

        //Cari Data
        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (txtCari.Text.Length > 0)
                CariData(txtCari.Text);
        }

        //Menampilkan Number
        private void dataGridViewJenis_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var g = (DataGridView)sender;
            var r = new Rectangle(e.RowBounds.Left, e.RowBounds.Top,
                g.RowHeadersWidth, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, $"{e.RowIndex + 1}",
                g.RowHeadersDefaultCellStyle.Font, r, g.RowHeadersDefaultCellStyle.ForeColor);
        }

        private void dataGridViewJenis_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var g = (DataGridView)sender;
            if (e.RowIndex > -1 && $"{g.Rows[e.RowIndex].HeaderCell.Value}" != $"{e.RowIndex + 1}")
            {
                g.Rows[e.RowIndex].HeaderCell.Value = $"{e.RowIndex + 1}";
            }
        }

        public class DataGridViewRowNumberColumn : DataGridViewColumn
        {
            public DataGridViewRowNumberColumn() : base()
            {
                this.CellTemplate = new DataGridViewRowNumberCell();
                this.Width = 40;
                this.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            [Browsable(false)]
            [DefaultValue(true)]
            public override bool ReadOnly
            {
                get { return true; }
                set { base.ReadOnly = true; }
            }
        }
        public class DataGridViewRowNumberCell : DataGridViewTextBoxCell
        {
            protected override void Paint(System.Drawing.Graphics graphics,
                System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds,
                int rowIndex, DataGridViewElementStates cellState, object value,
                object formattedValue, string errorText, DataGridViewCellStyle cellStyle,
                DataGridViewAdvancedBorderStyle advancedBorderStyle,
                DataGridViewPaintParts paintParts)
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value,
                    formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
            }
            protected override object GetValue(int rowIndex)
            {
                return rowIndex + 1;
            }
            protected override bool SetValue(int rowIndex, object value)
            {
                return base.SetValue(rowIndex, rowIndex + 1);
            }
        }
    }
}
