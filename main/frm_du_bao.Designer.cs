namespace main
{
    partial class frm_du_bao
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
            this.crtrpdubao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtnamdau = new System.Windows.Forms.TextBox();
            this.btnnamdau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crtrpdubao
            // 
            this.crtrpdubao.ActiveViewIndex = -1;
            this.crtrpdubao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtrpdubao.Cursor = System.Windows.Forms.Cursors.Default;
            this.crtrpdubao.Location = new System.Drawing.Point(-1, 48);
            this.crtrpdubao.Name = "crtrpdubao";
            this.crtrpdubao.Size = new System.Drawing.Size(878, 477);
            this.crtrpdubao.TabIndex = 0;
            this.crtrpdubao.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // txtnamdau
            // 
            this.txtnamdau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamdau.Location = new System.Drawing.Point(12, 12);
            this.txtnamdau.Multiline = true;
            this.txtnamdau.Name = "txtnamdau";
            this.txtnamdau.Size = new System.Drawing.Size(130, 30);
            this.txtnamdau.TabIndex = 1;
            // 
            // btnnamdau
            // 
            this.btnnamdau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnnamdau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnamdau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnamdau.Location = new System.Drawing.Point(148, 12);
            this.btnnamdau.Name = "btnnamdau";
            this.btnnamdau.Size = new System.Drawing.Size(100, 30);
            this.btnnamdau.TabIndex = 2;
            this.btnnamdau.Text = "Tìm kiếm";
            this.btnnamdau.UseVisualStyleBackColor = true;
            this.btnnamdau.Click += new System.EventHandler(this.btnnamdau_Click);
            // 
            // frm_du_bao
            // 
            this.AcceptButton = this.btnnamdau;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(878, 526);
            this.Controls.Add(this.btnnamdau);
            this.Controls.Add(this.txtnamdau);
            this.Controls.Add(this.crtrpdubao);
            this.Name = "frm_du_bao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dự báo";
            this.Load += new System.EventHandler(this.frm_du_bao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crtrpdubao;
        private System.Windows.Forms.TextBox txtnamdau;
        private System.Windows.Forms.Button btnnamdau;
    }
}