namespace main
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.cbnam = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuthongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuthongke = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudubao = new System.Windows.Forms.ToolStripMenuItem();
            this.cbcacQH = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttenQH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtkhac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtyte = new System.Windows.Forms.TextBox();
            this.txtcongngiep = new System.Windows.Forms.TextBox();
            this.txtsinhoat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvfind = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btntinhtoan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ttrphongto = new System.Windows.Forms.ToolStripButton();
            this.tttrthunho = new System.Windows.Forms.ToolStripButton();
            this.tttrbinhthuong = new System.Windows.Forms.ToolStripButton();
            this.ptbha = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfind)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbha)).BeginInit();
            this.SuspendLayout();
            // 
            // cbnam
            // 
            this.cbnam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnam.FormattingEnabled = true;
            this.cbnam.Location = new System.Drawing.Point(28, 42);
            this.cbnam.Name = "cbnam";
            this.cbnam.Size = new System.Drawing.Size(172, 27);
            this.cbnam.TabIndex = 0;
            this.cbnam.SelectedIndexChanged += new System.EventHandler(this.cbnam_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.mnuthongtin,
            this.mnuthongke,
            this.mnudubao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // mnuthongtin
            // 
            this.mnuthongtin.Name = "mnuthongtin";
            this.mnuthongtin.Size = new System.Drawing.Size(78, 21);
            this.mnuthongtin.Text = "Thông Tin";
            this.mnuthongtin.Click += new System.EventHandler(this.mnuthongtin_Click);
            // 
            // mnuthongke
            // 
            this.mnuthongke.Name = "mnuthongke";
            this.mnuthongke.Size = new System.Drawing.Size(76, 21);
            this.mnuthongke.Text = "Thống Kê";
            this.mnuthongke.Click += new System.EventHandler(this.mnuthongke_Click);
            // 
            // mnudubao
            // 
            this.mnudubao.Name = "mnudubao";
            this.mnudubao.Size = new System.Drawing.Size(64, 21);
            this.mnudubao.Text = "Dự báo";
            this.mnudubao.Click += new System.EventHandler(this.mnudubao_Click);
            // 
            // cbcacQH
            // 
            this.cbcacQH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbcacQH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcacQH.FormattingEnabled = true;
            this.cbcacQH.Location = new System.Drawing.Point(28, 24);
            this.cbcacQH.Name = "cbcacQH";
            this.cbcacQH.Size = new System.Drawing.Size(172, 397);
            this.cbcacQH.TabIndex = 2;
            this.cbcacQH.SelectedIndexChanged += new System.EventHandler(this.cbcacQH_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttenQH);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtnam);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txttong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtkhac);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtyte);
            this.groupBox1.Controls.Add(this.txtcongngiep);
            this.groupBox1.Controls.Add(this.txtsinhoat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(279, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 319);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txttenQH
            // 
            this.txttenQH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenQH.Location = new System.Drawing.Point(136, 71);
            this.txttenQH.Multiline = true;
            this.txttenQH.Name = "txttenQH";
            this.txttenQH.ReadOnly = true;
            this.txttenQH.Size = new System.Drawing.Size(145, 27);
            this.txttenQH.TabIndex = 13;
            this.txttenQH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tên QH:";
            // 
            // txtnam
            // 
            this.txtnam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnam.Location = new System.Drawing.Point(136, 31);
            this.txtnam.Multiline = true;
            this.txtnam.Name = "txtnam";
            this.txtnam.ReadOnly = true;
            this.txtnam.Size = new System.Drawing.Size(145, 27);
            this.txtnam.TabIndex = 11;
            this.txtnam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Năm:";
            // 
            // txttong
            // 
            this.txttong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttong.Location = new System.Drawing.Point(136, 278);
            this.txttong.Multiline = true;
            this.txttong.Name = "txttong";
            this.txttong.ReadOnly = true;
            this.txttong.Size = new System.Drawing.Size(145, 27);
            this.txttong.TabIndex = 9;
            this.txttong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng:";
            // 
            // txtkhac
            // 
            this.txtkhac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkhac.Location = new System.Drawing.Point(136, 236);
            this.txtkhac.Multiline = true;
            this.txtkhac.Name = "txtkhac";
            this.txtkhac.Size = new System.Drawing.Size(145, 27);
            this.txtkhac.TabIndex = 7;
            this.txtkhac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rác khác:";
            // 
            // txtyte
            // 
            this.txtyte.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyte.Location = new System.Drawing.Point(136, 193);
            this.txtyte.Multiline = true;
            this.txtyte.Name = "txtyte";
            this.txtyte.Size = new System.Drawing.Size(145, 27);
            this.txtyte.TabIndex = 5;
            this.txtyte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcongngiep
            // 
            this.txtcongngiep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcongngiep.Location = new System.Drawing.Point(136, 152);
            this.txtcongngiep.Multiline = true;
            this.txtcongngiep.Name = "txtcongngiep";
            this.txtcongngiep.Size = new System.Drawing.Size(145, 27);
            this.txtcongngiep.TabIndex = 3;
            this.txtcongngiep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsinhoat
            // 
            this.txtsinhoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsinhoat.Location = new System.Drawing.Point(136, 110);
            this.txtsinhoat.Multiline = true;
            this.txtsinhoat.Name = "txtsinhoat";
            this.txtsinhoat.Size = new System.Drawing.Size(145, 27);
            this.txtsinhoat.TabIndex = 1;
            this.txtsinhoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rác y tế:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rác công nghiệp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rác sinh hoạt:";
            // 
            // dgvfind
            // 
            this.dgvfind.BackgroundColor = System.Drawing.Color.White;
            this.dgvfind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvfind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfind.Location = new System.Drawing.Point(190, 10);
            this.dgvfind.Name = "dgvfind";
            this.dgvfind.Size = new System.Drawing.Size(10, 10);
            this.dgvfind.TabIndex = 4;
            this.dgvfind.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbcacQH);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 433);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm theo Tên QH";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btntinhtoan);
            this.groupBox3.Controls.Add(this.cbnam);
            this.groupBox3.Controls.Add(this.dgvfind);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 100);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm theo Năm";
            // 
            // btntinhtoan
            // 
            this.btntinhtoan.FlatAppearance.BorderSize = 0;
            this.btntinhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntinhtoan.ForeColor = System.Drawing.Color.White;
            this.btntinhtoan.Location = new System.Drawing.Point(212, 10);
            this.btntinhtoan.Name = "btntinhtoan";
            this.btntinhtoan.Size = new System.Drawing.Size(10, 10);
            this.btntinhtoan.TabIndex = 15;
            this.btntinhtoan.Text = "Tính Toán";
            this.btntinhtoan.UseVisualStyleBackColor = true;
            this.btntinhtoan.Click += new System.EventHandler(this.btntinhtoan_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(469, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 28);
            this.button2.TabIndex = 16;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(308, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(276, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(352, 34);
            this.label8.TabIndex = 19;
            this.label8.Text = "Sau khi đã thay đổi các chỉ số, \r\nnhấn enter để tự động cập nhật tổng chỉ số rác " +
    "của QH đó";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.ptbha);
            this.panel1.Location = new System.Drawing.Point(676, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 319);
            this.panel1.TabIndex = 23;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttrphongto,
            this.tttrthunho,
            this.tttrbinhthuong});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1076, 25);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ttrphongto
            // 
            this.ttrphongto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ttrphongto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttrphongto.Image = ((System.Drawing.Image)(resources.GetObject("ttrphongto.Image")));
            this.ttrphongto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttrphongto.Name = "ttrphongto";
            this.ttrphongto.Size = new System.Drawing.Size(23, 22);
            this.ttrphongto.Text = "Zoom";
            this.ttrphongto.Click += new System.EventHandler(this.ttrphongto_Click);
            // 
            // tttrthunho
            // 
            this.tttrthunho.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tttrthunho.Image = ((System.Drawing.Image)(resources.GetObject("tttrthunho.Image")));
            this.tttrthunho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tttrthunho.Name = "tttrthunho";
            this.tttrthunho.Size = new System.Drawing.Size(23, 22);
            this.tttrthunho.Text = "Zoom out";
            this.tttrthunho.Click += new System.EventHandler(this.tttrthunho_Click);
            // 
            // tttrbinhthuong
            // 
            this.tttrbinhthuong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tttrbinhthuong.Image = global::main.Properties.Resources.binhthuong;
            this.tttrbinhthuong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tttrbinhthuong.Name = "tttrbinhthuong";
            this.tttrbinhthuong.Size = new System.Drawing.Size(23, 22);
            this.tttrbinhthuong.Text = "Casual";
            this.tttrbinhthuong.Click += new System.EventHandler(this.tttrbinhthuong_Click);
            // 
            // ptbha
            // 
            this.ptbha.BackgroundImage = global::main.Properties.Resources.ban_do_vi_tri_dia_ly_gioi_hanh_chinh_tp_hcm;
            this.ptbha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbha.Location = new System.Drawing.Point(5, 0);
            this.ptbha.Name = "ptbha";
            this.ptbha.Size = new System.Drawing.Size(300, 319);
            this.ptbha.TabIndex = 20;
            this.ptbha.TabStop = false;
            // 
            // frm_main
            // 
            this.AcceptButton = this.btntinhtoan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 654);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao diện chính";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfind)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbnam;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuthongke;
        private System.Windows.Forms.ToolStripMenuItem mnudubao;
        private System.Windows.Forms.ToolStripMenuItem mnuthongtin;
        private System.Windows.Forms.ComboBox cbcacQH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtkhac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtyte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcongngiep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsinhoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvfind;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttenQH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btntinhtoan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox ptbha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ttrphongto;
        private System.Windows.Forms.ToolStripButton tttrthunho;
        private System.Windows.Forms.ToolStripButton tttrbinhthuong;
    }
}

