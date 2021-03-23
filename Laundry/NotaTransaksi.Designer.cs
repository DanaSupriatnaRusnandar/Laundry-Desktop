namespace Laundry
{
    partial class NotaTransaksi
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource13 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource14 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource15 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource16 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource17 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource18 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.laundryDataSet = new Laundry.laundryDataSet();
            this.tb_transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_transaksiTableAdapter = new Laundry.laundryDataSetTableAdapters.tb_transaksiTableAdapter();
            this.tb_memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_memberTableAdapter = new Laundry.laundryDataSetTableAdapters.tb_memberTableAdapter();
            this.tb_outletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_outletTableAdapter = new Laundry.laundryDataSetTableAdapters.tb_outletTableAdapter();
            this.tb_paketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_paketTableAdapter = new Laundry.laundryDataSetTableAdapters.tb_paketTableAdapter();
            this.tb_jenisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_jenisTableAdapter = new Laundry.laundryDataSetTableAdapters.tb_jenisTableAdapter();
            this.tb_detail_transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_detail_transaksiTableAdapter = new Laundry.laundryDataSetTableAdapters.tb_detail_transaksiTableAdapter();
            this.tb_userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_userTableAdapter = new Laundry.laundryDataSetTableAdapters.tb_userTableAdapter();
            this.tb_kurirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_kurirTableAdapter = new Laundry.laundryDataSetTableAdapters.tb_kurirTableAdapter();
            this.DataTableNotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableNotaTableAdapter = new Laundry.laundryDataSetTableAdapters.DataTableNotaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laundryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_transaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_outletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_paketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_jenisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_detail_transaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_kurirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableNotaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 520);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource10.Name = "DataSetTransaksi";
            reportDataSource10.Value = this.tb_transaksiBindingSource;
            reportDataSource11.Name = "DataSetMember";
            reportDataSource11.Value = this.tb_memberBindingSource;
            reportDataSource12.Name = "DataSetOutlet";
            reportDataSource12.Value = this.tb_outletBindingSource;
            reportDataSource13.Name = "DataSetPaket";
            reportDataSource13.Value = this.tb_paketBindingSource;
            reportDataSource14.Name = "DataSetJenis";
            reportDataSource14.Value = this.tb_jenisBindingSource;
            reportDataSource15.Name = "DataSetDetail";
            reportDataSource15.Value = this.tb_detail_transaksiBindingSource;
            reportDataSource16.Name = "DataSetUser";
            reportDataSource16.Value = this.tb_userBindingSource;
            reportDataSource17.Name = "DataSetKurir";
            reportDataSource17.Value = this.tb_kurirBindingSource;
            reportDataSource18.Name = "DataSetNota";
            reportDataSource18.Value = this.DataTableNotaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource12);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource13);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource14);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource15);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource16);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource17);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource18);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Laundry.NotaPembayaran.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(714, 520);
            this.reportViewer1.TabIndex = 0;
            // 
            // laundryDataSet
            // 
            this.laundryDataSet.DataSetName = "laundryDataSet";
            this.laundryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_transaksiBindingSource
            // 
            this.tb_transaksiBindingSource.DataMember = "tb_transaksi";
            this.tb_transaksiBindingSource.DataSource = this.laundryDataSet;
            // 
            // tb_transaksiTableAdapter
            // 
            this.tb_transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // tb_memberBindingSource
            // 
            this.tb_memberBindingSource.DataMember = "tb_member";
            this.tb_memberBindingSource.DataSource = this.laundryDataSet;
            // 
            // tb_memberTableAdapter
            // 
            this.tb_memberTableAdapter.ClearBeforeFill = true;
            // 
            // tb_outletBindingSource
            // 
            this.tb_outletBindingSource.DataMember = "tb_outlet";
            this.tb_outletBindingSource.DataSource = this.laundryDataSet;
            // 
            // tb_outletTableAdapter
            // 
            this.tb_outletTableAdapter.ClearBeforeFill = true;
            // 
            // tb_paketBindingSource
            // 
            this.tb_paketBindingSource.DataMember = "tb_paket";
            this.tb_paketBindingSource.DataSource = this.laundryDataSet;
            // 
            // tb_paketTableAdapter
            // 
            this.tb_paketTableAdapter.ClearBeforeFill = true;
            // 
            // tb_jenisBindingSource
            // 
            this.tb_jenisBindingSource.DataMember = "tb_jenis";
            this.tb_jenisBindingSource.DataSource = this.laundryDataSet;
            // 
            // tb_jenisTableAdapter
            // 
            this.tb_jenisTableAdapter.ClearBeforeFill = true;
            // 
            // tb_detail_transaksiBindingSource
            // 
            this.tb_detail_transaksiBindingSource.DataMember = "tb_detail_transaksi";
            this.tb_detail_transaksiBindingSource.DataSource = this.laundryDataSet;
            // 
            // tb_detail_transaksiTableAdapter
            // 
            this.tb_detail_transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // tb_userBindingSource
            // 
            this.tb_userBindingSource.DataMember = "tb_user";
            this.tb_userBindingSource.DataSource = this.laundryDataSet;
            // 
            // tb_userTableAdapter
            // 
            this.tb_userTableAdapter.ClearBeforeFill = true;
            // 
            // tb_kurirBindingSource
            // 
            this.tb_kurirBindingSource.DataMember = "tb_kurir";
            this.tb_kurirBindingSource.DataSource = this.laundryDataSet;
            // 
            // tb_kurirTableAdapter
            // 
            this.tb_kurirTableAdapter.ClearBeforeFill = true;
            // 
            // DataTableNotaBindingSource
            // 
            this.DataTableNotaBindingSource.DataMember = "DataTableNota";
            this.DataTableNotaBindingSource.DataSource = this.laundryDataSet;
            // 
            // DataTableNotaTableAdapter
            // 
            this.DataTableNotaTableAdapter.ClearBeforeFill = true;
            // 
            // NotaTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 520);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NotaTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.NotaTransaksi_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.laundryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_transaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_outletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_paketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_jenisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_detail_transaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_kurirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableNotaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_transaksiBindingSource;
        private laundryDataSet laundryDataSet;
        private System.Windows.Forms.BindingSource tb_memberBindingSource;
        private System.Windows.Forms.BindingSource tb_outletBindingSource;
        private System.Windows.Forms.BindingSource tb_paketBindingSource;
        private System.Windows.Forms.BindingSource tb_jenisBindingSource;
        private System.Windows.Forms.BindingSource tb_detail_transaksiBindingSource;
        private System.Windows.Forms.BindingSource tb_userBindingSource;
        private System.Windows.Forms.BindingSource tb_kurirBindingSource;
        private System.Windows.Forms.BindingSource DataTableNotaBindingSource;
        private laundryDataSetTableAdapters.tb_transaksiTableAdapter tb_transaksiTableAdapter;
        private laundryDataSetTableAdapters.tb_memberTableAdapter tb_memberTableAdapter;
        private laundryDataSetTableAdapters.tb_outletTableAdapter tb_outletTableAdapter;
        private laundryDataSetTableAdapters.tb_paketTableAdapter tb_paketTableAdapter;
        private laundryDataSetTableAdapters.tb_jenisTableAdapter tb_jenisTableAdapter;
        private laundryDataSetTableAdapters.tb_detail_transaksiTableAdapter tb_detail_transaksiTableAdapter;
        private laundryDataSetTableAdapters.tb_userTableAdapter tb_userTableAdapter;
        private laundryDataSetTableAdapters.tb_kurirTableAdapter tb_kurirTableAdapter;
        private laundryDataSetTableAdapters.DataTableNotaTableAdapter DataTableNotaTableAdapter;
    }
}