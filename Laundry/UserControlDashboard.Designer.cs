namespace Laundry
{
    partial class UserControlDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblJam = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblPelanggan = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblAmbil = new System.Windows.Forms.Label();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblHariTanggal = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblProses = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBaru = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblSelesai = new System.Windows.Forms.Label();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewTransaksi = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode_invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batas_waktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 65);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DASHBOARD";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblJam);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.lblHariTanggal);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 649);
            this.panel1.TabIndex = 2;
            // 
            // lblJam
            // 
            this.lblJam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJam.AutoSize = true;
            this.lblJam.Font = new System.Drawing.Font("Shrikhand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lblJam.Location = new System.Drawing.Point(13, 8);
            this.lblJam.Name = "lblJam";
            this.lblJam.Size = new System.Drawing.Size(45, 21);
            this.lblJam.TabIndex = 34;
            this.lblJam.Text = "Jam";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Goldenrod;
            this.panel8.Controls.Add(this.lblPelanggan);
            this.panel8.Controls.Add(this.iconPictureBox1);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Location = new System.Drawing.Point(23, 62);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 100);
            this.panel8.TabIndex = 36;
            // 
            // lblPelanggan
            // 
            this.lblPelanggan.AutoSize = true;
            this.lblPelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelanggan.ForeColor = System.Drawing.Color.White;
            this.lblPelanggan.Location = new System.Drawing.Point(161, 30);
            this.lblPelanggan.Name = "lblPelanggan";
            this.lblPelanggan.Size = new System.Drawing.Size(18, 20);
            this.lblPelanggan.TabIndex = 6;
            this.lblPelanggan.Text = "0";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 37;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 24);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(50, 37);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Jumlah Pelanggan";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(121)))), ((int)(((byte)(183)))));
            this.panel7.Controls.Add(this.lblAmbil);
            this.panel7.Controls.Add(this.iconPictureBox5);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(23, 541);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 40;
            // 
            // lblAmbil
            // 
            this.lblAmbil.AutoSize = true;
            this.lblAmbil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmbil.ForeColor = System.Drawing.Color.White;
            this.lblAmbil.Location = new System.Drawing.Point(161, 27);
            this.lblAmbil.Name = "lblAmbil";
            this.lblAmbil.Size = new System.Drawing.Size(18, 20);
            this.lblAmbil.TabIndex = 15;
            this.lblAmbil.Text = "0";
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.iconPictureBox5.IconColor = System.Drawing.Color.White;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 37;
            this.iconPictureBox5.Location = new System.Drawing.Point(11, 22);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(51, 37);
            this.iconPictureBox5.TabIndex = 14;
            this.iconPictureBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Jumlah Cucian Siap Ambil";
            // 
            // lblHariTanggal
            // 
            this.lblHariTanggal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHariTanggal.AutoSize = true;
            this.lblHariTanggal.Font = new System.Drawing.Font("Shrikhand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHariTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lblHariTanggal.Location = new System.Drawing.Point(13, 29);
            this.lblHariTanggal.Name = "lblHariTanggal";
            this.lblHariTanggal.Size = new System.Drawing.Size(151, 21);
            this.lblHariTanggal.TabIndex = 35;
            this.lblHariTanggal.Text = "Hari dan Tanggal";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.lblProses);
            this.panel5.Controls.Add(this.iconPictureBox3);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(23, 299);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 38;
            // 
            // lblProses
            // 
            this.lblProses.AutoSize = true;
            this.lblProses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProses.ForeColor = System.Drawing.Color.Sienna;
            this.lblProses.Location = new System.Drawing.Point(161, 27);
            this.lblProses.Name = "lblProses";
            this.lblProses.Size = new System.Drawing.Size(18, 20);
            this.lblProses.TabIndex = 9;
            this.lblProses.Text = "0";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.Sienna;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.iconPictureBox3.IconColor = System.Drawing.Color.Sienna;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 37;
            this.iconPictureBox3.Location = new System.Drawing.Point(8, 22);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(50, 37);
            this.iconPictureBox3.TabIndex = 8;
            this.iconPictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(5, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Jumlah Cucian Diproses";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(252)))), ((int)(((byte)(184)))));
            this.panel3.Controls.Add(this.lblBaru);
            this.panel3.Controls.Add(this.iconPictureBox2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(23, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 37;
            // 
            // lblBaru
            // 
            this.lblBaru.AutoSize = true;
            this.lblBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(121)))), ((int)(((byte)(183)))));
            this.lblBaru.Location = new System.Drawing.Point(161, 27);
            this.lblBaru.Name = "lblBaru";
            this.lblBaru.Size = new System.Drawing.Size(18, 20);
            this.lblBaru.TabIndex = 5;
            this.lblBaru.Text = "0";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(121)))), ((int)(((byte)(183)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(121)))), ((int)(((byte)(183)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 37;
            this.iconPictureBox2.Location = new System.Drawing.Point(10, 22);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(50, 37);
            this.iconPictureBox2.TabIndex = 4;
            this.iconPictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(121)))), ((int)(((byte)(183)))));
            this.label5.Location = new System.Drawing.Point(7, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Jumlah Cucian Baru";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.Controls.Add(this.lblSelesai);
            this.panel6.Controls.Add(this.iconPictureBox4);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(23, 419);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 39;
            // 
            // lblSelesai
            // 
            this.lblSelesai.AutoSize = true;
            this.lblSelesai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelesai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(191)))), ((int)(((byte)(20)))));
            this.lblSelesai.Location = new System.Drawing.Point(161, 27);
            this.lblSelesai.Name = "lblSelesai";
            this.lblSelesai.Size = new System.Drawing.Size(18, 20);
            this.lblSelesai.TabIndex = 12;
            this.lblSelesai.Text = "0";
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(191)))), ((int)(((byte)(20)))));
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconPictureBox4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(191)))), ((int)(((byte)(20)))));
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 37;
            this.iconPictureBox4.Location = new System.Drawing.Point(12, 22);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(46, 37);
            this.iconPictureBox4.TabIndex = 11;
            this.iconPictureBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(191)))), ((int)(((byte)(20)))));
            this.label9.Location = new System.Drawing.Point(9, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Jumlah Cucian Selesai";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dataGridViewTransaksi);
            this.panel4.Location = new System.Drawing.Point(262, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(492, 603);
            this.panel4.TabIndex = 5;
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
            this.no,
            this.kode_invoice,
            this.tgl,
            this.nama_member,
            this.jenis,
            this.batas_waktu,
            this.harga,
            this.status});
            this.dataGridViewTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTransaksi.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTransaksi.Name = "dataGridViewTransaksi";
            this.dataGridViewTransaksi.ReadOnly = true;
            this.dataGridViewTransaksi.RowHeadersWidth = 25;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTransaksi.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTransaksi.Size = new System.Drawing.Size(492, 603);
            this.dataGridViewTransaksi.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // no
            // 
            this.no.HeaderText = "No";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            // 
            // kode_invoice
            // 
            this.kode_invoice.HeaderText = "Invoice";
            this.kode_invoice.Name = "kode_invoice";
            this.kode_invoice.ReadOnly = true;
            // 
            // tgl
            // 
            this.tgl.HeaderText = "Tanggal";
            this.tgl.Name = "tgl";
            this.tgl.ReadOnly = true;
            // 
            // nama_member
            // 
            this.nama_member.HeaderText = "Pelanggan";
            this.nama_member.Name = "nama_member";
            this.nama_member.ReadOnly = true;
            // 
            // jenis
            // 
            this.jenis.HeaderText = "Jenis Paket";
            this.jenis.Name = "jenis";
            this.jenis.ReadOnly = true;
            // 
            // batas_waktu
            // 
            this.batas_waktu.HeaderText = "Batas Waktu";
            this.batas_waktu.Name = "batas_waktu";
            this.batas_waktu.ReadOnly = true;
            // 
            // harga
            // 
            this.harga.HeaderText = "Harga";
            this.harga.Name = "harga";
            this.harga.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // UserControlDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UserControlDashboard";
            this.Size = new System.Drawing.Size(788, 714);
            this.Load += new System.EventHandler(this.UserControlDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblJam;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblPelanggan;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblAmbil;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblHariTanggal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblProses;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBaru;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblSelesai;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_member;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn batas_waktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}
