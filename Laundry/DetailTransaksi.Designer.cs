namespace Laundry
{
    partial class DetailTransaksi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kode_invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batas_waktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_bayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_paket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biaya_tambahan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dikon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pajak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_pembayaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stastu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dibayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonLaki = new System.Windows.Forms.RadioButton();
            this.radioButtonPerempuan = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbltlp = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtNamaPelanggan = new System.Windows.Forms.TextBox();
            this.lblJk = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 55);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "DETAIL TRANSAKSI";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 199);
            this.panel2.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kode_invoice,
            this.tgl,
            this.batas_waktu,
            this.tgl_bayar,
            this.nama_paket,
            this.jenis,
            this.harga,
            this.qty,
            this.biaya_tambahan,
            this.dikon,
            this.pajak,
            this.total_pembayaran,
            this.stastu,
            this.dibayar,
            this.keterangan});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(725, 199);
            this.dataGridView1.TabIndex = 0;
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
            // batas_waktu
            // 
            this.batas_waktu.HeaderText = "Batas Waktu";
            this.batas_waktu.Name = "batas_waktu";
            this.batas_waktu.ReadOnly = true;
            // 
            // tgl_bayar
            // 
            this.tgl_bayar.HeaderText = "Tanggal Bayar";
            this.tgl_bayar.Name = "tgl_bayar";
            this.tgl_bayar.ReadOnly = true;
            // 
            // nama_paket
            // 
            this.nama_paket.HeaderText = "Paket";
            this.nama_paket.Name = "nama_paket";
            this.nama_paket.ReadOnly = true;
            // 
            // jenis
            // 
            this.jenis.HeaderText = "Jenis";
            this.jenis.Name = "jenis";
            this.jenis.ReadOnly = true;
            // 
            // harga
            // 
            this.harga.HeaderText = "harga";
            this.harga.Name = "harga";
            this.harga.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // biaya_tambahan
            // 
            this.biaya_tambahan.HeaderText = "Biaya Tambahan";
            this.biaya_tambahan.Name = "biaya_tambahan";
            this.biaya_tambahan.ReadOnly = true;
            // 
            // dikon
            // 
            this.dikon.HeaderText = "Diskon";
            this.dikon.Name = "dikon";
            this.dikon.ReadOnly = true;
            // 
            // pajak
            // 
            this.pajak.HeaderText = "Pajak";
            this.pajak.Name = "pajak";
            this.pajak.ReadOnly = true;
            // 
            // total_pembayaran
            // 
            this.total_pembayaran.HeaderText = "Total Pembayaran";
            this.total_pembayaran.Name = "total_pembayaran";
            this.total_pembayaran.ReadOnly = true;
            // 
            // stastu
            // 
            this.stastu.HeaderText = "Status";
            this.stastu.Name = "stastu";
            this.stastu.ReadOnly = true;
            // 
            // dibayar
            // 
            this.dibayar.HeaderText = "Pembayaran";
            this.dibayar.Name = "dibayar";
            this.dibayar.ReadOnly = true;
            // 
            // keterangan
            // 
            this.keterangan.HeaderText = "Catatan";
            this.keterangan.Name = "keterangan";
            this.keterangan.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.radioButtonLaki);
            this.panel3.Controls.Add(this.radioButtonPerempuan);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.Lbltlp);
            this.panel3.Controls.Add(this.lblAlamat);
            this.panel3.Controls.Add(this.txtNamaPelanggan);
            this.panel3.Controls.Add(this.lblJk);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 245);
            this.panel3.TabIndex = 15;
            // 
            // radioButtonLaki
            // 
            this.radioButtonLaki.AutoSize = true;
            this.radioButtonLaki.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonLaki.Location = new System.Drawing.Point(19, 97);
            this.radioButtonLaki.Name = "radioButtonLaki";
            this.radioButtonLaki.Size = new System.Drawing.Size(74, 17);
            this.radioButtonLaki.TabIndex = 9;
            this.radioButtonLaki.TabStop = true;
            this.radioButtonLaki.Text = "Laki - Laki";
            this.radioButtonLaki.UseVisualStyleBackColor = false;
            // 
            // radioButtonPerempuan
            // 
            this.radioButtonPerempuan.AutoSize = true;
            this.radioButtonPerempuan.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonPerempuan.Location = new System.Drawing.Point(99, 97);
            this.radioButtonPerempuan.Name = "radioButtonPerempuan";
            this.radioButtonPerempuan.Size = new System.Drawing.Size(79, 17);
            this.radioButtonPerempuan.TabIndex = 10;
            this.radioButtonPerempuan.TabStop = true;
            this.radioButtonPerempuan.Text = "Perempuan";
            this.radioButtonPerempuan.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(176, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            // 
            // Lbltlp
            // 
            this.Lbltlp.AutoSize = true;
            this.Lbltlp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltlp.Location = new System.Drawing.Point(13, 181);
            this.Lbltlp.Name = "Lbltlp";
            this.Lbltlp.Size = new System.Drawing.Size(80, 16);
            this.Lbltlp.TabIndex = 5;
            this.Lbltlp.Text = "No.Telepon";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlamat.Location = new System.Drawing.Point(13, 128);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(50, 16);
            this.lblAlamat.TabIndex = 4;
            this.lblAlamat.Text = "Alamat";
            // 
            // txtNamaPelanggan
            // 
            this.txtNamaPelanggan.Location = new System.Drawing.Point(16, 48);
            this.txtNamaPelanggan.Name = "txtNamaPelanggan";
            this.txtNamaPelanggan.ReadOnly = true;
            this.txtNamaPelanggan.Size = new System.Drawing.Size(175, 20);
            this.txtNamaPelanggan.TabIndex = 3;
            // 
            // lblJk
            // 
            this.lblJk.AutoSize = true;
            this.lblJk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJk.Location = new System.Drawing.Point(12, 77);
            this.lblJk.Name = "lblJk";
            this.lblJk.Size = new System.Drawing.Size(91, 16);
            this.lblJk.TabIndex = 2;
            this.lblJk.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nama Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "* Data Pelanggan";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textBox7);
            this.panel4.Controls.Add(this.textBox6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBox5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(521, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 245);
            this.panel4.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "No.Telepon";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(16, 200);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(175, 20);
            this.textBox7.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(16, 147);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(175, 20);
            this.textBox6.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kurir";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(16, 97);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(175, 20);
            this.textBox5.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Petugas";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(16, 48);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(175, 20);
            this.textBox4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nama Outlet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "* Data Outlet dan Pegawai";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(204, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(317, 245);
            this.panel5.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catatan";
            // 
            // textBox8
            // 
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.Location = new System.Drawing.Point(3, 18);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(311, 224);
            this.textBox8.TabIndex = 0;
            // 
            // DetailTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 499);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DetailTransaksi";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.DetailTransaksi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl;
        private System.Windows.Forms.DataGridViewTextBoxColumn batas_waktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_bayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_paket;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn biaya_tambahan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dikon;
        private System.Windows.Forms.DataGridViewTextBoxColumn pajak;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_pembayaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn stastu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dibayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn keterangan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButtonLaki;
        private System.Windows.Forms.RadioButton radioButtonPerempuan;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lbltlp;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtNamaPelanggan;
        private System.Windows.Forms.Label lblJk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox8;
    }
}