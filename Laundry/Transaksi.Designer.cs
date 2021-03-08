namespace Laundry
{
    partial class Transaksi
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtJenis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiskon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBiayaTambahan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPajak = new System.Windows.Forms.TextBox();
            this.btnHapus = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbPaket = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.dtpBatasWaktu = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbPelanggan = new System.Windows.Forms.ComboBox();
            this.cmbOutlet = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTotalPembayaran = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNominalBiayaTambahan = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxPajak = new System.Windows.Forms.TextBox();
            this.txtNominalPajak = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxDiskon = new System.Windows.Forms.TextBox();
            this.txtNominalDiskon = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.dtpTanggalBayar = new System.Windows.Forms.DateTimePicker();
            this.txtCatatan = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.cmbPetugas = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cmbKurir = new System.Windows.Forms.ComboBox();
            this.cmbDibayar = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "TAMBAH TRANSAKSI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 67);
            this.panel1.TabIndex = 7;
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btn_refresh.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_refresh.IconSize = 24;
            this.btn_refresh.Location = new System.Drawing.Point(922, 21);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(24, 24);
            this.btn_refresh.TabIndex = 16;
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label6.Location = new System.Drawing.Point(61, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Paket";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label7.Location = new System.Drawing.Point(261, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Jenis";
            // 
            // txtJenis
            // 
            this.txtJenis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtJenis.Location = new System.Drawing.Point(231, 31);
            this.txtJenis.Multiline = true;
            this.txtJenis.Name = "txtJenis";
            this.txtJenis.ReadOnly = true;
            this.txtJenis.Size = new System.Drawing.Size(95, 25);
            this.txtJenis.TabIndex = 9;
            this.txtJenis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label8.Location = new System.Drawing.Point(367, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Qty";
            // 
            // txtQty
            // 
            this.txtQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtQty.Location = new System.Drawing.Point(332, 31);
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(95, 25);
            this.txtQty.TabIndex = 10;
            this.txtQty.Text = "1,00";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label9.Location = new System.Drawing.Point(461, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Harga";
            // 
            // txtHarga
            // 
            this.txtHarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtHarga.Location = new System.Drawing.Point(433, 31);
            this.txtHarga.Multiline = true;
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.ReadOnly = true;
            this.txtHarga.Size = new System.Drawing.Size(95, 25);
            this.txtHarga.TabIndex = 11;
            this.txtHarga.Text = "0,00";
            this.txtHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHarga.TextChanged += new System.EventHandler(this.txtHarga_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label10.Location = new System.Drawing.Point(557, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Diskon";
            // 
            // txtDiskon
            // 
            this.txtDiskon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtDiskon.Location = new System.Drawing.Point(533, 31);
            this.txtDiskon.Multiline = true;
            this.txtDiskon.Name = "txtDiskon";
            this.txtDiskon.Size = new System.Drawing.Size(95, 25);
            this.txtDiskon.TabIndex = 12;
            this.txtDiskon.Text = "0,00";
            this.txtDiskon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiskon.TextChanged += new System.EventHandler(this.txtDiskon_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label11.Location = new System.Drawing.Point(624, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Biaya Tambahan";
            // 
            // txtBiayaTambahan
            // 
            this.txtBiayaTambahan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtBiayaTambahan.Location = new System.Drawing.Point(634, 31);
            this.txtBiayaTambahan.Multiline = true;
            this.txtBiayaTambahan.Name = "txtBiayaTambahan";
            this.txtBiayaTambahan.Size = new System.Drawing.Size(95, 25);
            this.txtBiayaTambahan.TabIndex = 13;
            this.txtBiayaTambahan.Text = "0,00";
            this.txtBiayaTambahan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBiayaTambahan.TextChanged += new System.EventHandler(this.txtBiayaTambahan_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label12.Location = new System.Drawing.Point(763, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "Pajak";
            // 
            // txtPajak
            // 
            this.txtPajak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtPajak.Location = new System.Drawing.Point(735, 31);
            this.txtPajak.Multiline = true;
            this.txtPajak.Name = "txtPajak";
            this.txtPajak.Size = new System.Drawing.Size(95, 25);
            this.txtPajak.TabIndex = 14;
            this.txtPajak.Text = "0,00";
            this.txtPajak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPajak.TextChanged += new System.EventHandler(this.txtPajak_TextChanged);
            // 
            // btnHapus
            // 
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnHapus.IconColor = System.Drawing.Color.Red;
            this.btnHapus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHapus.IconSize = 30;
            this.btnHapus.Location = new System.Drawing.Point(16, 31);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Rotation = 45D;
            this.btnHapus.Size = new System.Drawing.Size(32, 27);
            this.btnHapus.TabIndex = 34;
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(16, 64);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(125, 32);
            this.iconButton1.TabIndex = 35;
            this.iconButton1.Text = "Tambah Paket";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label13.Location = new System.Drawing.Point(864, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 16);
            this.label13.TabIndex = 36;
            this.label13.Text = "Total";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cmbPaket);
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.btnHapus);
            this.panel3.Controls.Add(this.txtPajak);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtBiayaTambahan);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtDiskon);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtHarga);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtQty);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtJenis);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(949, 109);
            this.panel3.TabIndex = 9;
            // 
            // cmbPaket
            // 
            this.cmbPaket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cmbPaket.FormattingEnabled = true;
            this.cmbPaket.Location = new System.Drawing.Point(53, 32);
            this.cmbPaket.Name = "cmbPaket";
            this.cmbPaket.Size = new System.Drawing.Size(172, 23);
            this.cmbPaket.TabIndex = 8;
            this.cmbPaket.SelectedIndexChanged += new System.EventHandler(this.cmbPaket_SelectedIndexChanged);
            this.cmbPaket.SelectionChangeCommitted += new System.EventHandler(this.cmbPaket_SelectionChangeCommitted);
            // 
            // txtTotal
            // 
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtTotal.Location = new System.Drawing.Point(836, 31);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(95, 25);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.Text = "0,00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(50, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Outlet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(50, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Pelanggan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(466, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tanggal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(466, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Batas Waktu";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 20;
            this.btnAdd.Location = new System.Drawing.Point(370, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(26, 25);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Location = new System.Drawing.Point(584, 19);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(218, 20);
            this.dtpTanggal.TabIndex = 4;
            // 
            // dtpBatasWaktu
            // 
            this.dtpBatasWaktu.Location = new System.Drawing.Point(584, 60);
            this.dtpBatasWaktu.Name = "dtpBatasWaktu";
            this.dtpBatasWaktu.Size = new System.Drawing.Size(218, 20);
            this.dtpBatasWaktu.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbPelanggan);
            this.panel2.Controls.Add(this.cmbOutlet);
            this.panel2.Controls.Add(this.dtpBatasWaktu);
            this.panel2.Controls.Add(this.dtpTanggal);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 124);
            this.panel2.TabIndex = 8;
            // 
            // cmbPelanggan
            // 
            this.cmbPelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPelanggan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cmbPelanggan.FormattingEnabled = true;
            this.cmbPelanggan.Location = new System.Drawing.Point(145, 55);
            this.cmbPelanggan.Name = "cmbPelanggan";
            this.cmbPelanggan.Size = new System.Drawing.Size(219, 23);
            this.cmbPelanggan.TabIndex = 2;
            // 
            // cmbOutlet
            // 
            this.cmbOutlet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOutlet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cmbOutlet.FormattingEnabled = true;
            this.cmbOutlet.Location = new System.Drawing.Point(146, 18);
            this.cmbOutlet.Name = "cmbOutlet";
            this.cmbOutlet.Size = new System.Drawing.Size(218, 23);
            this.cmbOutlet.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.txtTotalPembayaran);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.txtNominalBiayaTambahan);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.textBoxPajak);
            this.panel4.Controls.Add(this.txtNominalPajak);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.textBoxDiskon);
            this.panel4.Controls.Add(this.txtNominalDiskon);
            this.panel4.Controls.Add(this.txtGrandTotal);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 300);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(949, 184);
            this.panel4.TabIndex = 10;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label20.Location = new System.Drawing.Point(522, 144);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 16);
            this.label20.TabIndex = 38;
            this.label20.Text = "Total Pembayaran";
            // 
            // txtTotalPembayaran
            // 
            this.txtTotalPembayaran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtTotalPembayaran.Location = new System.Drawing.Point(652, 139);
            this.txtTotalPembayaran.Multiline = true;
            this.txtTotalPembayaran.Name = "txtTotalPembayaran";
            this.txtTotalPembayaran.ReadOnly = true;
            this.txtTotalPembayaran.Size = new System.Drawing.Size(279, 25);
            this.txtTotalPembayaran.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label19.Location = new System.Drawing.Point(530, 112);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 16);
            this.label19.TabIndex = 38;
            this.label19.Text = "Biaya Tambahan";
            // 
            // txtNominalBiayaTambahan
            // 
            this.txtNominalBiayaTambahan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtNominalBiayaTambahan.Location = new System.Drawing.Point(652, 108);
            this.txtNominalBiayaTambahan.Multiline = true;
            this.txtNominalBiayaTambahan.Name = "txtNominalBiayaTambahan";
            this.txtNominalBiayaTambahan.Size = new System.Drawing.Size(279, 25);
            this.txtNominalBiayaTambahan.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label18.Location = new System.Drawing.Point(603, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 16);
            this.label18.TabIndex = 38;
            this.label18.Text = "Pajak";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label17.Location = new System.Drawing.Point(596, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 16);
            this.label17.TabIndex = 38;
            this.label17.Text = "Diskon";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Gainsboro;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label16.Location = new System.Drawing.Point(755, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 25);
            this.label16.TabIndex = 43;
            this.label16.Text = "%";
            // 
            // textBoxPajak
            // 
            this.textBoxPajak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.textBoxPajak.Location = new System.Drawing.Point(652, 77);
            this.textBoxPajak.Multiline = true;
            this.textBoxPajak.Name = "textBoxPajak";
            this.textBoxPajak.Size = new System.Drawing.Size(129, 25);
            this.textBoxPajak.TabIndex = 19;
            // 
            // txtNominalPajak
            // 
            this.txtNominalPajak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtNominalPajak.Location = new System.Drawing.Point(791, 77);
            this.txtNominalPajak.Multiline = true;
            this.txtNominalPajak.Name = "txtNominalPajak";
            this.txtNominalPajak.Size = new System.Drawing.Size(140, 25);
            this.txtNominalPajak.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Gainsboro;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label15.Location = new System.Drawing.Point(755, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 25);
            this.label15.TabIndex = 40;
            this.label15.Text = "%";
            // 
            // textBoxDiskon
            // 
            this.textBoxDiskon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.textBoxDiskon.Location = new System.Drawing.Point(652, 46);
            this.textBoxDiskon.Multiline = true;
            this.textBoxDiskon.Name = "textBoxDiskon";
            this.textBoxDiskon.Size = new System.Drawing.Size(129, 25);
            this.textBoxDiskon.TabIndex = 17;
            // 
            // txtNominalDiskon
            // 
            this.txtNominalDiskon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtNominalDiskon.Location = new System.Drawing.Point(791, 46);
            this.txtNominalDiskon.Multiline = true;
            this.txtNominalDiskon.Name = "txtNominalDiskon";
            this.txtNominalDiskon.Size = new System.Drawing.Size(140, 25);
            this.txtNominalDiskon.TabIndex = 18;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtGrandTotal.Location = new System.Drawing.Point(652, 15);
            this.txtGrandTotal.Multiline = true;
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(279, 25);
            this.txtGrandTotal.TabIndex = 16;
            this.txtGrandTotal.Text = "0,00";
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrandTotal.TextChanged += new System.EventHandler(this.txtGrandTotal_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label14.Location = new System.Drawing.Point(567, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 16);
            this.label14.TabIndex = 38;
            this.label14.Text = "Grand Total";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(506, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 27;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(629, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 32);
            this.button2.TabIndex = 28;
            this.button2.Text = "Simpan dan Cetak";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label21.Location = new System.Drawing.Point(20, 12);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 16);
            this.label21.TabIndex = 54;
            this.label21.Text = "Dibayar";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label22.Location = new System.Drawing.Point(20, 68);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 16);
            this.label22.TabIndex = 56;
            this.label22.Text = "Status";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label23.Location = new System.Drawing.Point(20, 42);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(98, 16);
            this.label23.TabIndex = 58;
            this.label23.Text = "Tanggal Bayar";
            // 
            // dtpTanggalBayar
            // 
            this.dtpTanggalBayar.Location = new System.Drawing.Point(139, 42);
            this.dtpTanggalBayar.Name = "dtpTanggalBayar";
            this.dtpTanggalBayar.Size = new System.Drawing.Size(247, 20);
            this.dtpTanggalBayar.TabIndex = 24;
            // 
            // txtCatatan
            // 
            this.txtCatatan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtCatatan.Location = new System.Drawing.Point(139, 99);
            this.txtCatatan.Multiline = true;
            this.txtCatatan.Name = "txtCatatan";
            this.txtCatatan.Size = new System.Drawing.Size(247, 54);
            this.txtCatatan.TabIndex = 26;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label24.Location = new System.Drawing.Point(20, 122);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 16);
            this.label24.TabIndex = 60;
            this.label24.Text = "Catatan";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(139, 69);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(247, 23);
            this.cmbStatus.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.cmbPetugas);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.cmbKurir);
            this.panel5.Controls.Add(this.cmbStatus);
            this.panel5.Controls.Add(this.cmbDibayar);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.txtCatatan);
            this.panel5.Controls.Add(this.dtpTanggalBayar);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 484);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(949, 162);
            this.panel5.TabIndex = 11;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label26.Location = new System.Drawing.Point(442, 46);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 16);
            this.label26.TabIndex = 63;
            this.label26.Text = "Petugas";
            // 
            // cmbPetugas
            // 
            this.cmbPetugas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPetugas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cmbPetugas.FormattingEnabled = true;
            this.cmbPetugas.Location = new System.Drawing.Point(506, 44);
            this.cmbPetugas.Name = "cmbPetugas";
            this.cmbPetugas.Size = new System.Drawing.Size(255, 23);
            this.cmbPetugas.TabIndex = 62;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label25.Location = new System.Drawing.Point(442, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(34, 16);
            this.label25.TabIndex = 44;
            this.label25.Text = "Kurir";
            // 
            // cmbKurir
            // 
            this.cmbKurir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKurir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cmbKurir.FormattingEnabled = true;
            this.cmbKurir.Location = new System.Drawing.Point(506, 15);
            this.cmbKurir.Name = "cmbKurir";
            this.cmbKurir.Size = new System.Drawing.Size(255, 23);
            this.cmbKurir.TabIndex = 61;
            // 
            // cmbDibayar
            // 
            this.cmbDibayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDibayar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cmbDibayar.FormattingEnabled = true;
            this.cmbDibayar.Location = new System.Drawing.Point(139, 15);
            this.cmbDibayar.Name = "cmbDibayar";
            this.cmbDibayar.Size = new System.Drawing.Size(247, 23);
            this.cmbDibayar.TabIndex = 23;
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 668);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Transaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Transaksi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtJenis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiskon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBiayaTambahan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPajak;
        private FontAwesome.Sharp.IconButton btnHapus;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.DateTimePicker dtpBatasWaktu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbPelanggan;
        private System.Windows.Forms.ComboBox cmbOutlet;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTotalPembayaran;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNominalBiayaTambahan;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxPajak;
        private System.Windows.Forms.TextBox txtNominalPajak;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxDiskon;
        private System.Windows.Forms.TextBox txtNominalDiskon;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpTanggalBayar;
        private System.Windows.Forms.TextBox txtCatatan;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmbDibayar;
        private System.Windows.Forms.ComboBox cmbPaket;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cmbPetugas;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cmbKurir;
        private FontAwesome.Sharp.IconButton btn_refresh;
    }
}