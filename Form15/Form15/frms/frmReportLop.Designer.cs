namespace Form15.frms
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
            this.rpdLop = new Form15.frms.CrystalReportLop();
            this.SuspendLayout();
            // 
            // rpvLop
            // 
            this.rpvLop.ActiveViewIndex = -1;
            this.rpvLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpvLop.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpvLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvLop.Location = new System.Drawing.Point(0, 0);
            this.rpvLop.Name = "rpvLop";
            this.rpvLop.Size = new System.Drawing.Size(800, 450);
            this.rpvLop.TabIndex = 0;
            this.rpvLop.Load += new System.EventHandler(this.rpvLop_Load);
            // 
            // frmReportKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvLop);
            this.Name = "frmReportKhoa";
            this.Text = "Report Lớp";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpvLop;
        private CrystalReportLop rpdLop;
    }
}