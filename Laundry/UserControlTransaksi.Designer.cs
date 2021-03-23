namespace Laundry
{
    partial class UserControlTransaksi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewTransaksi = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_refresh = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnTambah = new FontAwesome.Sharp.IconButton();
            this.btnHapus = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_outlet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode_invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batas_waktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_bayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biaya_tambahan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diskon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pajak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_pembayaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dibayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_kurir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksi)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCari
            // 
            this.txtCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtCari.Location = new System.Drawing.Point(85, 16);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(143, 20);
            this.txtCari.TabIndex = 3;
            this.txtCari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(4, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cari Data :";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dataGridViewTransaksi);
            this.panel4.Location = new System.Drawing.Point(39, 152);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(641, 377);
            this.panel4.TabIndex = 4;
            // 
            // dataGridViewTransaksi
            // 
            this.dataGridViewTransaksi.AllowUserToAddRows = false;
            this.dataGridViewTransaksi.AllowUserToDeleteRows = false;
            this.dataGridViewTransaksi.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTransaksi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTransaksi.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTransaksi.ColumnHeadersHeight = 38;
            this.dataGridViewTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nama_outlet,
            this.kode_invoice,
            this.nama_member,
            this.tgl,
            this.batas_waktu,
            this.tgl_bayar,
            this.biaya_tambahan,
            this.diskon,
            this.pajak,
            this.total_pembayaran,
            this.status,
            this.dibayar,
            this.nama_kurir,
            this.nama,
            this.edit});
            this.dataGridViewTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTransaksi.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTransaksi.Name = "dataGridViewTransaksi";
            this.dataGridViewTransaksi.ReadOnly = true;
            this.dataGridViewTransaksi.RowHeadersWidth = 35;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTransaksi.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTransaksi.Size = new System.Drawing.Size(641, 377);
            this.dataGridViewTransaksi.TabIndex = 0;
            this.dataGridViewTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransaksi_CellClick);
            this.dataGridViewTransaksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransaksi_CellContentClick);
            this.dataGridViewTransaksi.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewTransaksi_RowPostPaint);
            this.dataGridViewTransaksi.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewTransaksi_RowPrePaint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtCari);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btn_refresh);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(417, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 50);
            this.panel3.TabIndex = 12;
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btn_refresh.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_refresh.IconSize = 24;
            this.btn_refresh.Location = new System.Drawing.Point(234, 13);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(24, 24);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 115);
            this.panel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnTambah);
            this.panel5.Controls.Add(this.btnHapus);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(118, 50);
            this.panel5.TabIndex = 14;
            // 
            // btnTambah
            // 
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnTambah.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnTambah.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTambah.IconSize = 30;
            this.btnTambah.Location = new System.Drawing.Point(39, 9);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(32, 32);
            this.btnTambah.TabIndex = 30;
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click_1);
            // 
            // btnHapus
            // 
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnHapus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnHapus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHapus.IconSize = 30;
            this.btnHapus.Location = new System.Drawing.Point(77, 9);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(32, 32);
            this.btnHapus.TabIndex = 2;
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 65);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANSAKSI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(36, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Total Pemasukan:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtTotal.Location = new System.Drawing.Point(164, 124);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(140, 21);
            this.txtTotal.TabIndex = 33;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nama_outlet
            // 
            this.nama_outlet.DataPropertyName = "nama_outlet";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.nama_outlet.DefaultCellStyle = dataGridViewCellStyle3;
            this.nama_outlet.HeaderText = "Outlet";
            this.nama_outlet.Name = "nama_outlet";
            this.nama_outlet.ReadOnly = true;
            // 
            // kode_invoice
            // 
            this.kode_invoice.DataPropertyName = "kode_invoice";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.kode_invoice.DefaultCellStyle = dataGridViewCellStyle4;
            this.kode_invoice.HeaderText = "Invoice";
            this.kode_invoice.Name = "kode_invoice";
            this.kode_invoice.ReadOnly = true;
            // 
            // nama_member
            // 
            this.nama_member.DataPropertyName = "nama_member";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.nama_member.DefaultCellStyle = dataGridViewCellStyle5;
            this.nama_member.HeaderText = "Pelanggan";
            this.nama_member.Name = "nama_member";
            this.nama_member.ReadOnly = true;
            // 
            // tgl
            // 
            this.tgl.DataPropertyName = "tgl";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.tgl.DefaultCellStyle = dataGridViewCellStyle6;
            this.tgl.HeaderText = "Tanggal";
            this.tgl.Name = "tgl";
            this.tgl.ReadOnly = true;
            // 
            // batas_waktu
            // 
            this.batas_waktu.DataPropertyName = "batas_waktu";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.batas_waktu.DefaultCellStyle = dataGridViewCellStyle7;
            this.batas_waktu.HeaderText = "Batas Waktu";
            this.batas_waktu.Name = "batas_waktu";
            this.batas_waktu.ReadOnly = true;
            // 
            // tgl_bayar
            // 
            this.tgl_bayar.DataPropertyName = "tgl_bayar";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.tgl_bayar.DefaultCellStyle = dataGridViewCellStyle8;
            this.tgl_bayar.HeaderText = "Tanggal Bayar";
            this.tgl_bayar.Name = "tgl_bayar";
            this.tgl_bayar.ReadOnly = true;
            this.tgl_bayar.Visible = false;
            // 
            // biaya_tambahan
            // 
            this.biaya_tambahan.DataPropertyName = "biaya_tambahan";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.biaya_tambahan.DefaultCellStyle = dataGridViewCellStyle9;
            this.biaya_tambahan.HeaderText = "Biaya Tambahan";
            this.biaya_tambahan.Name = "biaya_tambahan";
            this.biaya_tambahan.ReadOnly = true;
            this.biaya_tambahan.Visible = false;
            // 
            // diskon
            // 
            this.diskon.DataPropertyName = "diskon";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.diskon.DefaultCellStyle = dataGridViewCellStyle10;
            this.diskon.HeaderText = "Diskon";
            this.diskon.Name = "diskon";
            this.diskon.ReadOnly = true;
            this.diskon.Visible = false;
            // 
            // pajak
            // 
            this.pajak.DataPropertyName = "pajak";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.pajak.DefaultCellStyle = dataGridViewCellStyle11;
            this.pajak.HeaderText = "Pajak";
            this.pajak.Name = "pajak";
            this.pajak.ReadOnly = true;
            this.pajak.Visible = false;
            // 
            // total_pembayaran
            // 
            this.total_pembayaran.DataPropertyName = "total_pembayaran";
            this.total_pembayaran.HeaderText = "Total";
            this.total_pembayaran.Name = "total_pembayaran";
            this.total_pembayaran.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.status.DefaultCellStyle = dataGridViewCellStyle12;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // dibayar
            // 
            this.dibayar.DataPropertyName = "dibayar";
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.dibayar.DefaultCellStyle = dataGridViewCellStyle13;
            this.dibayar.HeaderText = "Pembayaran";
            this.dibayar.Name = "dibayar";
            this.dibayar.ReadOnly = true;
            // 
            // nama_kurir
            // 
            this.nama_kurir.DataPropertyName = "nama_kurir";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.nama_kurir.DefaultCellStyle = dataGridViewCellStyle14;
            this.nama_kurir.HeaderText = "Kurir";
            this.nama_kurir.Name = "nama_kurir";
            this.nama_kurir.ReadOnly = true;
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nama";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.nama.DefaultCellStyle = dataGridViewCellStyle15;
            this.nama.HeaderText = "Petugas";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(184)))));
            this.edit.HeaderText = "";
            this.edit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.edit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(184)))));
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Edit";
            this.edit.TrackVisitedState = false;
            this.edit.UseColumnTextForLinkValue = true;
            this.edit.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(184)))));
            // 
            // UserControlTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlTransaksi";
            this.Size = new System.Drawing.Size(720, 565);
            this.Load += new System.EventHandler(this.UserControlTransaksi_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksi)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnHapus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridViewTransaksi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private FontAwesome.Sharp.IconButton btnTambah;
        private FontAwesome.Sharp.IconButton btn_refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_outlet;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_member;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl;
        private System.Windows.Forms.DataGridViewTextBoxColumn batas_waktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_bayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn biaya_tambahan;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskon;
        private System.Windows.Forms.DataGridViewTextBoxColumn pajak;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_pembayaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dibayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_kurir;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewLinkColumn edit;
    }
}
