﻿namespace Form07_static
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUCLN_BCNN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPTB1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPTB2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXuLyMang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUCLN_BCNN,
            this.mnuPTB1,
            this.mnuPTB2,
            this.mnuXuLyMang});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // mnuUCLN_BCNN
            // 
            this.mnuUCLN_BCNN.Name = "mnuUCLN_BCNN";
            this.mnuUCLN_BCNN.Size = new System.Drawing.Size(273, 26);
            this.mnuUCLN_BCNN.Text = "Ước số chung - Bội số chung";
            this.mnuUCLN_BCNN.Click += new System.EventHandler(this.mnuUCLN_BCNN_Click);
            // 
            // mnuPTB1
            // 
            this.mnuPTB1.Name = "mnuPTB1";
            this.mnuPTB1.Size = new System.Drawing.Size(273, 26);
            this.mnuPTB1.Text = "Giải phương trình bậc 1";
            this.mnuPTB1.Click += new System.EventHandler(this.mnuPTB1_Click);
            // 
            // mnuPTB2
            // 
            this.mnuPTB2.Name = "mnuPTB2";
            this.mnuPTB2.Size = new System.Drawing.Size(273, 26);
            this.mnuPTB2.Text = "Giải phương trình bậc 2";
            this.mnuPTB2.Click += new System.EventHandler(this.mnuPTB2_Click);
            // 
            // mnuXuLyMang
            // 
            this.mnuXuLyMang.Name = "mnuXuLyMang";
            this.mnuXuLyMang.Size = new System.Drawing.Size(273, 26);
            this.mnuXuLyMang.Text = "Xử lý mảng";
            this.mnuXuLyMang.Click += new System.EventHandler(this.mnuXuLyMang_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 468);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUCLN_BCNN;
        private System.Windows.Forms.ToolStripMenuItem mnuPTB1;
        private System.Windows.Forms.ToolStripMenuItem mnuPTB2;
        private System.Windows.Forms.ToolStripMenuItem mnuXuLyMang;
    }
}

