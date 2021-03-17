namespace Laundry
{
    partial class UserControlPaketLaundry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewpaket = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_outlet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_paket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_jenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_refresh = new FontAwesome.Sharp.IconButton();
            this.btnCari = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnHapus = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTambah = new FontAwesome.Sharp.IconButton();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpaket)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dataGridViewpaket);
            this.panel4.Location = new System.Drawing.Point(38, 151);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(746, 357);
            this.panel4.TabIndex = 4;
            // 
            // dataGridViewpaket
            // 
            this.dataGridViewpaket.AllowUserToAddRows = false;
            this.dataGridViewpaket.AllowUserToDeleteRows = false;
            this.dataGridViewpaket.AllowUserToResizeColumns = false;
            this.dataGridViewpaket.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewpaket.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewpaket.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewpaket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewpaket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewpaket.ColumnHeadersHeight = 38;
            this.dataGridViewpaket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewpaket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nama_outlet,
            this.nama_paket,
            this.id_jenis,
            this.jenis,
            this.harga,
            this.edit});
            this.dataGridViewpaket.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewpaket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewpaket.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewpaket.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewpaket.Name = "dataGridViewpaket";
            this.dataGridViewpaket.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewpaket.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewpaket.RowHeadersWidth = 25;
            this.dataGridViewpaket.Size = new System.Drawing.Size(746, 357);
            this.dataGridViewpaket.TabIndex = 1;
            this.dataGridViewpaket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewpaket_CellClick);
            this.dataGridViewpaket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewpaket_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID Paket";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Visible = false;
            // 
            // nama_outlet
            // 
            this.nama_outlet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama_outlet.DataPropertyName = "nama_outlet";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            this.nama_outlet.DefaultCellStyle = dataGridViewCellStyle19;
            this.nama_outlet.HeaderText = "Outlet";
            this.nama_outlet.Name = "nama_outlet";
            this.nama_outlet.ReadOnly = true;
            // 
            // nama_paket
            // 
            this.nama_paket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama_paket.DataPropertyName = "nama_paket";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.nama_paket.DefaultCellStyle = dataGridViewCellStyle20;
            this.nama_paket.FillWeight = 80F;
            this.nama_paket.HeaderText = "Nama Paket";
            this.nama_paket.Name = "nama_paket";
            this.nama_paket.ReadOnly = true;
            // 
            // id_jenis
            // 
            this.id_jenis.DataPropertyName = "id_jenis";
            this.id_jenis.FillWeight = 50F;
            this.id_jenis.HeaderText = "id_jenis";
            this.id_jenis.Name = "id_jenis";
            this.id_jenis.ReadOnly = true;
            this.id_jenis.Visible = false;
            // 
            // jenis
            // 
            this.jenis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jenis.DataPropertyName = "jenis";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            this.jenis.DefaultCellStyle = dataGridViewCellStyle21;
            this.jenis.FillWeight = 50F;
            this.jenis.HeaderText = "Jenis Paket";
            this.jenis.Name = "jenis";
            this.jenis.ReadOnly = true;
            this.jenis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // harga
            // 
            this.harga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.harga.DataPropertyName = "harga";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            this.harga.DefaultCellStyle = dataGridViewCellStyle22;
            this.harga.FillWeight = 50F;
            this.harga.HeaderText = "Harga";
            this.harga.Name = "harga";
            this.harga.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            this.edit.DefaultCellStyle = dataGridViewCellStyle23;
            this.edit.FillWeight = 30F;
            this.edit.HeaderText = "";
            this.edit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.edit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(184)))));
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.Text = "Edit";
            this.edit.TrackVisitedState = false;
            this.edit.UseColumnTextForLinkValue = true;
            this.edit.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(184)))));
            // 
            // txtCari
            // 
            this.txtCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtCari.Location = new System.Drawing.Point(85, 16);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(143, 20);
            this.txtCari.TabIndex = 3;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtCari);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btn_refresh);
            this.panel3.Controls.Add(this.btnCari);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(491, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 50);
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
            this.btn_refresh.Location = new System.Drawing.Point(264, 13);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(24, 24);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btnCari
            // 
            this.btnCari.FlatAppearance.BorderSize = 0;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnCari.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnCari.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCari.IconSize = 24;
            this.btnCari.Location = new System.Drawing.Point(234, 12);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(24, 24);
            this.btnCari.TabIndex = 4;
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 115);
            this.panel1.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnTambah);
            this.panel6.Controls.Add(this.btnHapus);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 65);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(125, 50);
            this.panel6.TabIndex = 14;
            // 
            // btnHapus
            // 
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnHapus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnHapus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHapus.IconSize = 30;
            this.btnHapus.Location = new System.Drawing.Point(76, 9);
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
            this.panel2.Size = new System.Drawing.Size(825, 65);
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
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAKET LAUNDRY";
            // 
            // btnTambah
            // 
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnTambah.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnTambah.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTambah.IconSize = 30;
            this.btnTambah.Location = new System.Drawing.Point(38, 9);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(32, 32);
            this.btnTambah.TabIndex = 28;
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // UserControlPaketLaundry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlPaketLaundry";
            this.Size = new System.Drawing.Size(825, 545);
            this.Load += new System.EventHandler(this.UserControlPaketLaundry_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpaket)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCari;
        private FontAwesome.Sharp.IconButton btnHapus;
        private FontAwesome.Sharp.IconButton btn_refresh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewpaket;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_outlet;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_paket;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_jenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewLinkColumn edit;
        private FontAwesome.Sharp.IconButton btnTambah;
    }
}
