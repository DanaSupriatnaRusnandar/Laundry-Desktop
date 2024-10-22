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
using Laundry.TambahData;

namespace Laundry
{
    public partial class UserControlOutlet : UserControl
    {
        public UserControlOutlet()
        {
            InitializeComponent();
        }
        string getIdOutlet;

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

        public void Tampilkan()
        {
            DataTable data = Db.Read("tb_outlet", "*");
            dataGridViewOtlet.AutoGenerateColumns = false;
            dataGridViewOtlet.DataSource = data;
        }

        private void CariData(string keyword)
        {
            dataGridViewOtlet.AutoGenerateColumns = false;
            dataGridViewOtlet.DataSource = Db.Read($"SELECT * FROM tb_outlet WHERE CONCAT(tb_outlet.nama_outlet, tb_outlet.alamat, tb_outlet.no_tlp) LIKE '%{keyword}%'");
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Tampilkan();
            txtCari.Clear();
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin menghapus data outlet Ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_outlet", $"id = {getIdOutlet}");
                Tampilkan();
                MessageBox.Show("Data outlet berhasil dihapus!");

            }
        }

        //Event Hapus
        private void dataGridViewOtlet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewOtlet.CurrentCell.RowIndex;
            getIdOutlet = dataGridViewOtlet.Rows[row].Cells["id"].Value.ToString();
        }

        //Event Edit
        private void dataGridViewOtlet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewOtlet.Columns["edit"].Index)
            {
                var row = dataGridViewOtlet.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                string nama = row.Cells["nama_outlet"].Value.ToString();
                string alamat = row.Cells["alamat"].Value.ToString();
                string tlp = row.Cells["no_tlp"].Value.ToString();
                new EditDataOutlet(btn_refresh, id, nama, alamat, tlp).ShowDialog();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            new TambahDataOutlet (btn_refresh).ShowDialog();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (txtCari.Text.Length > 0)
                CariData(txtCari.Text);
        }

        //Menampilkan Number
        private void dataGridViewOtlet_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var g = (DataGridView)sender;
            var r = new Rectangle(e.RowBounds.Left, e.RowBounds.Top,
                g.RowHeadersWidth, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, $"{e.RowIndex + 1}",
                g.RowHeadersDefaultCellStyle.Font, r, g.RowHeadersDefaultCellStyle.ForeColor);
        }

        private void dataGridViewOtlet_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
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
