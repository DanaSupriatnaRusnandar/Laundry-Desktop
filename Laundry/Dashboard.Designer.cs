namespace Laundry
{
    partial class Dashboard
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnKeluar = new FontAwesome.Sharp.IconButton();
            this.btnPengaturan = new FontAwesome.Sharp.IconButton();
            this.btnLaporan = new FontAwesome.Sharp.IconButton();
            this.btnTransaksi = new FontAwesome.Sharp.IconButton();
            this.btnPaketCucian = new FontAwesome.Sharp.IconButton();
            this.btnJenisPaket = new FontAwesome.Sharp.IconButton();
            this.btnOutlet = new FontAwesome.Sharp.IconButton();
            this.panelData = new System.Windows.Forms.Panel();
            this.btnPelanggan = new FontAwesome.Sharp.IconButton();
            this.BtnDataAdmin = new FontAwesome.Sharp.IconButton();
            this.btnAkun = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pageWrapper = new System.Windows.Forms.Panel();
            this.lblHariTanggal = new System.Windows.Forms.Label();
            this.lblJam = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pageWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Controls.Add(this.btnMaximize);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(550, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 37);
            this.panel3.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(10, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(26, 22);
            this.btnMinimize.TabIndex = 20;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
            // 
            // btnMaximize
            // 
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(44, 7);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(26, 22);
            this.btnMaximize.TabIndex = 21;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(78, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 22);
            this.btnClose.TabIndex = 22;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(198, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 37);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnKeluar);
            this.panelMenu.Controls.Add(this.btnPengaturan);
            this.panelMenu.Controls.Add(this.btnLaporan);
            this.panelMenu.Controls.Add(this.btnTransaksi);
            this.panelMenu.Controls.Add(this.btnPaketCucian);
            this.panelMenu.Controls.Add(this.btnJenisPaket);
            this.panelMenu.Controls.Add(this.btnOutlet);
            this.panelMenu.Controls.Add(this.panelData);
            this.panelMenu.Controls.Add(this.btnAkun);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(198, 712);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKeluar.FlatAppearance.BorderSize = 0;
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKeluar.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnKeluar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnKeluar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKeluar.IconSize = 32;
            this.btnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeluar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKeluar.Location = new System.Drawing.Point(0, 539);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnKeluar.Size = new System.Drawing.Size(198, 50);
            this.btnKeluar.TabIndex = 10;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKeluar.UseMnemonic = false;
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click_1);
            // 
            // btnPengaturan
            // 
            this.btnPengaturan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPengaturan.FlatAppearance.BorderSize = 0;
            this.btnPengaturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengaturan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPengaturan.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnPengaturan.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPengaturan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPengaturan.IconSize = 32;
            this.btnPengaturan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPengaturan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPengaturan.Location = new System.Drawing.Point(0, 489);
            this.btnPengaturan.Name = "btnPengaturan";
            this.btnPengaturan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPengaturan.Size = new System.Drawing.Size(198, 50);
            this.btnPengaturan.TabIndex = 9;
            this.btnPengaturan.Text = "Pengaturan";
            this.btnPengaturan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPengaturan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPengaturan.UseMnemonic = false;
            this.btnPengaturan.UseVisualStyleBackColor = true;
            this.btnPengaturan.Click += new System.EventHandler(this.btnPengaturan_Click_1);
            // 
            // btnLaporan
            // 
            this.btnLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLaporan.FlatAppearance.BorderSize = 0;
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLaporan.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnLaporan.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLaporan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLaporan.IconSize = 32;
            this.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaporan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLaporan.Location = new System.Drawing.Point(0, 439);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLaporan.Size = new System.Drawing.Size(198, 50);
            this.btnLaporan.TabIndex = 8;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLaporan.UseMnemonic = false;
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click_1);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaksi.FlatAppearance.BorderSize = 0;
            this.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaksi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTransaksi.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnTransaksi.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTransaksi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransaksi.IconSize = 32;
            this.btnTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaksi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTransaksi.Location = new System.Drawing.Point(0, 389);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTransaksi.Size = new System.Drawing.Size(198, 50);
            this.btnTransaksi.TabIndex = 7;
            this.btnTransaksi.Text = "Transaksi";
            this.btnTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransaksi.UseMnemonic = false;
            this.btnTransaksi.UseVisualStyleBackColor = true;
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click_1);
            // 
            // btnPaketCucian
            // 
            this.btnPaketCucian.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaketCucian.FlatAppearance.BorderSize = 0;
            this.btnPaketCucian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaketCucian.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPaketCucian.IconChar = FontAwesome.Sharp.IconChar.Tshirt;
            this.btnPaketCucian.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPaketCucian.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPaketCucian.IconSize = 32;
            this.btnPaketCucian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaketCucian.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPaketCucian.Location = new System.Drawing.Point(0, 339);
            this.btnPaketCucian.Name = "btnPaketCucian";
            this.btnPaketCucian.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPaketCucian.Size = new System.Drawing.Size(198, 50);
            this.btnPaketCucian.TabIndex = 6;
            this.btnPaketCucian.Text = "Paket Laundry";
            this.btnPaketCucian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaketCucian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaketCucian.UseMnemonic = false;
            this.btnPaketCucian.UseVisualStyleBackColor = true;
            this.btnPaketCucian.Click += new System.EventHandler(this.btnPaketCucian_Click);
            // 
            // btnJenisPaket
            // 
            this.btnJenisPaket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJenisPaket.FlatAppearance.BorderSize = 0;
            this.btnJenisPaket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJenisPaket.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnJenisPaket.IconChar = FontAwesome.Sharp.IconChar.Tshirt;
            this.btnJenisPaket.IconColor = System.Drawing.Color.Gainsboro;
            this.btnJenisPaket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnJenisPaket.IconSize = 32;
            this.btnJenisPaket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJenisPaket.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnJenisPaket.Location = new System.Drawing.Point(0, 289);
            this.btnJenisPaket.Name = "btnJenisPaket";
            this.btnJenisPaket.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnJenisPaket.Size = new System.Drawing.Size(198, 50);
            this.btnJenisPaket.TabIndex = 5;
            this.btnJenisPaket.Text = "Jenis Paket";
            this.btnJenisPaket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJenisPaket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJenisPaket.UseMnemonic = false;
            this.btnJenisPaket.UseVisualStyleBackColor = true;
            this.btnJenisPaket.Click += new System.EventHandler(this.btnJenisPaket_Click_1);
            // 
            // btnOutlet
            // 
            this.btnOutlet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOutlet.FlatAppearance.BorderSize = 0;
            this.btnOutlet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutlet.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOutlet.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btnOutlet.IconColor = System.Drawing.Color.Gainsboro;
            this.btnOutlet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOutlet.IconSize = 32;
            this.btnOutlet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutlet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOutlet.Location = new System.Drawing.Point(0, 239);
            this.btnOutlet.Name = "btnOutlet";
            this.btnOutlet.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOutlet.Size = new System.Drawing.Size(198, 50);
            this.btnOutlet.TabIndex = 4;
            this.btnOutlet.Text = "Outlet";
            this.btnOutlet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutlet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOutlet.UseMnemonic = false;
            this.btnOutlet.UseVisualStyleBackColor = true;
            this.btnOutlet.Click += new System.EventHandler(this.btnOutlet_Click);
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.btnPelanggan);
            this.panelData.Controls.Add(this.BtnDataAdmin);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelData.Location = new System.Drawing.Point(0, 139);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(198, 100);
            this.panelData.TabIndex = 4;
            // 
            // btnPelanggan
            // 
            this.btnPelanggan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPelanggan.FlatAppearance.BorderSize = 0;
            this.btnPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPelanggan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPelanggan.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnPelanggan.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPelanggan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPelanggan.IconSize = 32;
            this.btnPelanggan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPelanggan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPelanggan.Location = new System.Drawing.Point(0, 50);
            this.btnPelanggan.Name = "btnPelanggan";
            this.btnPelanggan.Padding = new System.Windows.Forms.Padding(36, 0, 20, 0);
            this.btnPelanggan.Size = new System.Drawing.Size(198, 50);
            this.btnPelanggan.TabIndex = 3;
            this.btnPelanggan.Text = "Registrasi Pelanggan";
            this.btnPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPelanggan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPelanggan.UseMnemonic = false;
            this.btnPelanggan.UseVisualStyleBackColor = true;
            this.btnPelanggan.Click += new System.EventHandler(this.btnPelanggan_Click);
            // 
            // BtnDataAdmin
            // 
            this.BtnDataAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDataAdmin.FlatAppearance.BorderSize = 0;
            this.BtnDataAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDataAdmin.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnDataAdmin.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.BtnDataAdmin.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnDataAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDataAdmin.IconSize = 32;
            this.BtnDataAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDataAdmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnDataAdmin.Location = new System.Drawing.Point(0, 0);
            this.BtnDataAdmin.Name = "BtnDataAdmin";
            this.BtnDataAdmin.Padding = new System.Windows.Forms.Padding(36, 0, 20, 0);
            this.BtnDataAdmin.Size = new System.Drawing.Size(198, 50);
            this.BtnDataAdmin.TabIndex = 2;
            this.BtnDataAdmin.Text = "Data User";
            this.BtnDataAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDataAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDataAdmin.UseMnemonic = false;
            this.BtnDataAdmin.UseVisualStyleBackColor = true;
            this.BtnDataAdmin.Click += new System.EventHandler(this.BtnDataAdmin_Click_1);
            // 
            // btnAkun
            // 
            this.btnAkun.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAkun.FlatAppearance.BorderSize = 0;
            this.btnAkun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAkun.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAkun.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnAkun.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAkun.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAkun.IconSize = 32;
            this.btnAkun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAkun.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAkun.Location = new System.Drawing.Point(0, 89);
            this.btnAkun.Name = "btnAkun";
            this.btnAkun.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAkun.Size = new System.Drawing.Size(198, 50);
            this.btnAkun.TabIndex = 1;
            this.btnAkun.Text = "Data & Akun";
            this.btnAkun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAkun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAkun.UseMnemonic = false;
            this.btnAkun.UseVisualStyleBackColor = true;
            this.btnAkun.Click += new System.EventHandler(this.btnAkun_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 89);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "XENZA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "CLEAN WASH";
            // 
            // pageWrapper
            // 
            this.pageWrapper.Controls.Add(this.lblHariTanggal);
            this.pageWrapper.Controls.Add(this.lblJam);
            this.pageWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageWrapper.Location = new System.Drawing.Point(198, 37);
            this.pageWrapper.Name = "pageWrapper";
            this.pageWrapper.Size = new System.Drawing.Size(662, 675);
            this.pageWrapper.TabIndex = 2;
            // 
            // lblHariTanggal
            // 
            this.lblHariTanggal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHariTanggal.AutoSize = true;
            this.lblHariTanggal.Font = new System.Drawing.Font("Permanent Marker", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHariTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lblHariTanggal.Location = new System.Drawing.Point(3, 41);
            this.lblHariTanggal.Name = "lblHariTanggal";
            this.lblHariTanggal.Size = new System.Drawing.Size(243, 35);
            this.lblHariTanggal.TabIndex = 1;
            this.lblHariTanggal.Text = "Hari dan Tanggal";
            // 
            // lblJam
            // 
            this.lblJam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJam.AutoSize = true;
            this.lblJam.Font = new System.Drawing.Font("Permanent Marker", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lblJam.Location = new System.Drawing.Point(3, 3);
            this.lblJam.Name = "lblJam";
            this.lblJam.Size = new System.Drawing.Size(68, 35);
            this.lblJam.TabIndex = 0;
            this.lblJam.Text = "Jam";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 712);
            this.Controls.Add(this.pageWrapper);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(860, 525);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardAdmin";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pageWrapper.ResumeLayout(false);
            this.pageWrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel pageWrapper;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnAkun;
        private System.Windows.Forms.Panel panelData;
        private FontAwesome.Sharp.IconButton BtnDataAdmin;
        private FontAwesome.Sharp.IconButton btnPelanggan;
        private FontAwesome.Sharp.IconButton btnOutlet;
        private FontAwesome.Sharp.IconButton btnJenisPaket;
        private FontAwesome.Sharp.IconButton btnPaketCucian;
        private FontAwesome.Sharp.IconButton btnTransaksi;
        private FontAwesome.Sharp.IconButton btnLaporan;
        private FontAwesome.Sharp.IconButton btnPengaturan;
        private FontAwesome.Sharp.IconButton btnKeluar;
        private System.Windows.Forms.Label lblHariTanggal;
        private System.Windows.Forms.Label lblJam;
        private System.Windows.Forms.Timer timer1;
    }
}