namespace Laundry
{
    partial class LaporanTransaksi
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tb_transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laundryDataSet = new Laundry.laundryDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_transaksiTableAdapter = new Laundry.laundryDataSetTableAdapters.tb_transaksiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_transaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_transaksiBindingSource
            // 
            this.tb_transaksiBindingSource.DataMember = "tb_transaksi";
            this.tb_transaksiBindingSource.DataSource = this.laundryDataSet;
            // 
            // laundryDataSet
            // 
            this.laundryDataSet.DataSetName = "laundryDataSet";
            this.laundryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_transaksiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Laundry.ReportTransaksi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(835, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // tb_transaksiTableAdapter
            // 
            this.tb_transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // LaporanTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LaporanTransaksi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LaporanPengeluaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_transaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_transaksiBindingSource;
        private laundryDataSet laundryDataSet;
        private laundryDataSetTableAdapters.tb_transaksiTableAdapter tb_transaksiTableAdapter;
    }
}