namespace Form16.frms
{
    partial class frmReportLop
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
            this.rpvLop = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rpdLop = new Form16.frms.CrystalReportLop();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rpvLop
            // 
            this.rpvLop.ActiveViewIndex = -1;
            this.rpvLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpvLop.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpvLop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rpvLop.Location = new System.Drawing.Point(0, 61);
            this.rpvLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rpvLop.Name = "rpvLop";
            this.rpvLop.Size = new System.Drawing.Size(980, 597);
            this.rpvLop.TabIndex = 0;
            this.rpvLop.ToolPanelWidth = 300;
            this.rpvLop.Load += new System.EventHandler(this.rpvLop_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lựa chọn khoa";
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(203, 6);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(386, 33);
            this.cbKhoa.TabIndex = 2;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(624, 6);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(109, 33);
            this.btnHienThi.TabIndex = 3;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // frmReportLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 658);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpvLop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReportLop";
            this.Text = "frmReportLop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpvLop;
        private CrystalReportLop rpdLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Button btnHienThi;
    }
}