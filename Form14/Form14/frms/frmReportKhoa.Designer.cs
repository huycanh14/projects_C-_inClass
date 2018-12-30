namespace Form14.frms
{
    partial class frmReportKhoa
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
            this.rpvKhoa = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport11 = new Form14.frms.CrystalReportKhoa();
            this.rpdKhoa = new Form14.frms.CrystalReportKhoa();
            this.CrystalReportKhoa1 = new Form14.frms.CrystalReportKhoa();
            this.SuspendLayout();
            // 
            // rpvKhoa
            // 
            this.rpvKhoa.ActiveViewIndex = 0;
            this.rpvKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpvKhoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpvKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvKhoa.Location = new System.Drawing.Point(0, 0);
            this.rpvKhoa.Name = "rpvKhoa";
            this.rpvKhoa.ReportSource = this.CrystalReportKhoa1;
            this.rpvKhoa.Size = new System.Drawing.Size(800, 450);
            this.rpvKhoa.TabIndex = 0;
            this.rpvKhoa.Load += new System.EventHandler(this.rpvKhoa_Load);
            // 
            // frmReportKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvKhoa);
            this.Name = "frmReportKhoa";
            this.Text = "frmReportKhoa";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpvKhoa;
        private CrystalReportKhoa rpdKhoa;
        private frms.CrystalReportKhoa CrystalReport11;
        private CrystalReportKhoa CrystalReportKhoa1;
    }
}