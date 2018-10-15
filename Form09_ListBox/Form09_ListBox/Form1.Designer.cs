namespace Form09_ListBox
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lstLeft = new System.Windows.Forms.ListBox();
            this.lstRight = new System.Windows.Forms.ListBox();
            this.txtThem = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMoveOnLeftToRight = new System.Windows.Forms.Button();
            this.btnMoveAllLeftToRight = new System.Windows.Forms.Button();
            this.btnMoveOneRightToLeft = new System.Windows.Forms.Button();
            this.btnMoveAllRightToLeft = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.txtThem);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(833, 541);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lstLeft);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(833, 443);
            this.splitContainer2.SplitterDistance = 355;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btnClose);
            this.splitContainer3.Panel1.Controls.Add(this.btnMoveAllRightToLeft);
            this.splitContainer3.Panel1.Controls.Add(this.btnMoveOneRightToLeft);
            this.splitContainer3.Panel1.Controls.Add(this.btnMoveAllLeftToRight);
            this.splitContainer3.Panel1.Controls.Add(this.btnMoveOnLeftToRight);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.lstRight);
            this.splitContainer3.Size = new System.Drawing.Size(477, 443);
            this.splitContainer3.SplitterDistance = 110;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 0;
            // 
            // lstLeft
            // 
            this.lstLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLeft.FormattingEnabled = true;
            this.lstLeft.ItemHeight = 29;
            this.lstLeft.Location = new System.Drawing.Point(12, 21);
            this.lstLeft.Name = "lstLeft";
            this.lstLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLeft.Size = new System.Drawing.Size(333, 410);
            this.lstLeft.TabIndex = 0;
            // 
            // lstRight
            // 
            this.lstRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRight.FormattingEnabled = true;
            this.lstRight.ItemHeight = 29;
            this.lstRight.Location = new System.Drawing.Point(21, 21);
            this.lstRight.Name = "lstRight";
            this.lstRight.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstRight.Size = new System.Drawing.Size(333, 410);
            this.lstRight.TabIndex = 0;
            // 
            // txtThem
            // 
            this.txtThem.Location = new System.Drawing.Point(12, 27);
            this.txtThem.Multiline = true;
            this.txtThem.Name = "txtThem";
            this.txtThem.Size = new System.Drawing.Size(288, 34);
            this.txtThem.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(323, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMoveOnLeftToRight
            // 
            this.btnMoveOnLeftToRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveOnLeftToRight.Location = new System.Drawing.Point(3, 104);
            this.btnMoveOnLeftToRight.Name = "btnMoveOnLeftToRight";
            this.btnMoveOnLeftToRight.Size = new System.Drawing.Size(104, 43);
            this.btnMoveOnLeftToRight.TabIndex = 0;
            this.btnMoveOnLeftToRight.Text = ">";
            this.btnMoveOnLeftToRight.UseVisualStyleBackColor = true;
            this.btnMoveOnLeftToRight.Click += new System.EventHandler(this.btnMoveOnLeftToRight_Click);
            // 
            // btnMoveAllLeftToRight
            // 
            this.btnMoveAllLeftToRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveAllLeftToRight.Location = new System.Drawing.Point(3, 175);
            this.btnMoveAllLeftToRight.Name = "btnMoveAllLeftToRight";
            this.btnMoveAllLeftToRight.Size = new System.Drawing.Size(104, 43);
            this.btnMoveAllLeftToRight.TabIndex = 0;
            this.btnMoveAllLeftToRight.Text = ">>";
            this.btnMoveAllLeftToRight.UseVisualStyleBackColor = true;
            this.btnMoveAllLeftToRight.Click += new System.EventHandler(this.btnMoveAllLeftToRight_Click);
            // 
            // btnMoveOneRightToLeft
            // 
            this.btnMoveOneRightToLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveOneRightToLeft.Location = new System.Drawing.Point(3, 246);
            this.btnMoveOneRightToLeft.Name = "btnMoveOneRightToLeft";
            this.btnMoveOneRightToLeft.Size = new System.Drawing.Size(104, 43);
            this.btnMoveOneRightToLeft.TabIndex = 0;
            this.btnMoveOneRightToLeft.Text = "<";
            this.btnMoveOneRightToLeft.UseVisualStyleBackColor = true;
            this.btnMoveOneRightToLeft.Click += new System.EventHandler(this.btnMoveOneRightToLeft_Click);
            // 
            // btnMoveAllRightToLeft
            // 
            this.btnMoveAllRightToLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveAllRightToLeft.Location = new System.Drawing.Point(3, 317);
            this.btnMoveAllRightToLeft.Name = "btnMoveAllRightToLeft";
            this.btnMoveAllRightToLeft.Size = new System.Drawing.Size(104, 43);
            this.btnMoveAllRightToLeft.TabIndex = 0;
            this.btnMoveAllRightToLeft.Text = "<<";
            this.btnMoveAllRightToLeft.UseVisualStyleBackColor = true;
            this.btnMoveAllRightToLeft.Click += new System.EventHandler(this.btnMoveAllRightToLeft_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(3, 388);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 43);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 541);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ListBox lstLeft;
        private System.Windows.Forms.ListBox lstRight;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtThem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMoveAllRightToLeft;
        private System.Windows.Forms.Button btnMoveOneRightToLeft;
        private System.Windows.Forms.Button btnMoveAllLeftToRight;
        private System.Windows.Forms.Button btnMoveOnLeftToRight;
    }
}

