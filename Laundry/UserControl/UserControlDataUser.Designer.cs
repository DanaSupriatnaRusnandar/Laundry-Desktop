namespace Laundry
{
    partial class UserControlDataUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnTambah = new FontAwesome.Sharp.IconButton();
            this.btnHapus = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_refresh = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_outlet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_outlet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 65);
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
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA USER";
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
            this.panel1.Size = new System.Drawing.Size(709, 115);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnTambah);
            this.panel5.Controls.Add(this.btnHapus);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(119, 50);
            this.panel5.TabIndex = 13;
            // 
            // btnTambah
            // 
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnTambah.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnTambah.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTambah.IconSize = 30;
            this.btnTambah.Location = new System.Drawing.Point(39, 10);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(32, 32);
            this.btnTambah.TabIndex = 20;
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnHapus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnHapus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHapus.IconSize = 30;
            this.btnHapus.Location = new System.Drawing.Point(77, 10);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(32, 32);
            this.btnHapus.TabIndex = 21;
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtCari);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btn_refresh);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(408, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 50);
            this.panel3.TabIndex = 12;
            // 
            // txtCari
            // 
            this.txtCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtCari.Location = new System.Drawing.Point(85, 16);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(143, 20);
            this.txtCari.TabIndex = 22;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cari Data :";
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btn_refresh.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_refresh.IconSize = 24;
            this.btn_refresh.Location = new System.Drawing.Point(234, 14);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(24, 24);
            this.btn_refresh.TabIndex = 24;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dataGridViewAdmin);
            this.panel4.Location = new System.Drawing.Point(39, 152);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(630, 357);
            this.panel4.TabIndex = 2;
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.AllowUserToAddRows = false;
            this.dataGridViewAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewAdmin.AllowUserToResizeColumns = false;
            this.dataGridViewAdmin.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewAdmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewAdmin.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewAdmin.ColumnHeadersHeight = 38;
            this.dataGridViewAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nama,
            this.username,
            this.password,
            this.id_outlet,
            this.nama_outlet,
            this.role,
            this.edit});
            this.dataGridViewAdmin.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAdmin.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.ReadOnly = true;
            this.dataGridViewAdmin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewAdmin.RowHeadersWidth = 35;
            this.dataGridViewAdmin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(630, 357);
            this.dataGridViewAdmin.TabIndex = 26;
            this.dataGridViewAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellClick);
            this.dataGridViewAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellContentClick);
            this.dataGridViewAdmin.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewAdmin_RowPostPaint);
            this.dataGridViewAdmin.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewAdmin_RowPrePaint);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nama
            // 
            this.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama.DataPropertyName = "nama";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.nama.DefaultCellStyle = dataGridViewCellStyle12;
            this.nama.HeaderText = "Nama Lengkap";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.username.DataPropertyName = "username";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.username.DefaultCellStyle = dataGridViewCellStyle13;
            this.username.FillWeight = 50F;
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.password.DataPropertyName = "password";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.password.DefaultCellStyle = dataGridViewCellStyle14;
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // id_outlet
            // 
            this.id_outlet.DataPropertyName = "id_outlet";
            this.id_outlet.HeaderText = "id_outlet";
            this.id_outlet.Name = "id_outlet";
            this.id_outlet.ReadOnly = true;
            this.id_outlet.Visible = false;
            // 
            // nama_outlet
            // 
            this.nama_outlet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama_outlet.DataPropertyName = "nama_outlet";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.nama_outlet.DefaultCellStyle = dataGridViewCellStyle15;
            this.nama_outlet.HeaderText = "Outlet";
            this.nama_outlet.Name = "nama_outlet";
            this.nama_outlet.ReadOnly = true;
            // 
            // role
            // 
            this.role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.role.DataPropertyName = "role";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.role.DefaultCellStyle = dataGridViewCellStyle16;
            this.role.FillWeight = 50F;
            this.role.HeaderText = "Hak Akses";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(184)))));
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            this.edit.DefaultCellStyle = dataGridViewCellStyle17;
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
            // UserControlDataUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlDataUser";
            this.Size = new System.Drawing.Size(709, 545);
            this.Load += new System.EventHandler(this.UserControlDataAdmin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnHapus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btn_refresh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnTambah;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_outlet;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_outlet;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewLinkColumn edit;
    }
}
