namespace Laundry
{
    partial class UserControlLaporanTransaksi
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCari = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDari = new System.Windows.Forms.DateTimePicker();
            this.btnCari = new FontAwesome.Sharp.IconButton();
            this.dateTimePickerSampai = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.laundryDataSet = new Laundry.laundryDataSet();
            this.DataTableTransaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableTransaksiTableAdapter = new Laundry.laundryDataSetTableAdapters.DataTableTransaksiTableAdapter();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laundryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableTransaksiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LAPORAN TRANSAKSI";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 65);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.txtCari);
            this.panel4.Controls.Add(this.dateTimePickerDari);
            this.panel4.Controls.Add(this.btnCari);
            this.panel4.Controls.Add(this.dateTimePickerSampai);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(825, 62);
            this.panel4.TabIndex = 5;
            // 
            // txtCari
            // 
            this.txtCari.FormattingEnabled = true;
            this.txtCari.Location = new System.Drawing.Point(355, 17);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(157, 21);
            this.txtCari.TabIndex = 7;
            // 
            // dateTimePickerDari
            // 
            this.dateTimePickerDari.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDari.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDari.Location = new System.Drawing.Point(47, 16);
            this.dateTimePickerDari.Name = "dateTimePickerDari";
            this.dateTimePickerDari.Size = new System.Drawing.Size(125, 20);
            this.dateTimePickerDari.TabIndex = 6;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnCari.FlatAppearance.BorderSize = 0;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCari.IconColor = System.Drawing.Color.Black;
            this.btnCari.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCari.Location = new System.Drawing.Point(526, 18);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 4;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // dateTimePickerSampai
            // 
            this.dateTimePickerSampai.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSampai.Location = new System.Drawing.Point(212, 17);
            this.dateTimePickerSampai.Name = "dateTimePickerSampai";
            this.dateTimePickerSampai.Size = new System.Drawing.Size(125, 20);
            this.dateTimePickerSampai.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(178, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "s/d";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dari";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 364);
            this.panel1.TabIndex = 6;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetTransaksi";
            reportDataSource1.Value = this.DataTableTransaksiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Laundry.Report.ReportTransaksi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(823, 362);
            this.reportViewer1.TabIndex = 0;
            // 
            // laundryDataSet
            // 
            this.laundryDataSet.DataSetName = "laundryDataSet";
            this.laundryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTableTransaksiBindingSource
            // 
            this.DataTableTransaksiBindingSource.DataMember = "DataTableTransaksi";
            this.DataTableTransaksiBindingSource.DataSource = this.laundryDataSet;
            // 
            // DataTableTransaksiTableAdapter
            // 
            this.DataTableTransaksiTableAdapter.ClearBeforeFill = true;
            // 
            // UserControlLaporanTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "UserControlLaporanTransaksi";
            this.Size = new System.Drawing.Size(825, 491);
            this.Load += new System.EventHandler(this.UserControlLaporanTransaksi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.laundryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableTransaksiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnCari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerSampai;
        private System.Windows.Forms.DateTimePicker dateTimePickerDari;
        private System.Windows.Forms.ComboBox txtCari;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableTransaksiBindingSource;
        private laundryDataSet laundryDataSet;
        private laundryDataSetTableAdapters.DataTableTransaksiTableAdapter DataTableTransaksiTableAdapter;
    }
}
