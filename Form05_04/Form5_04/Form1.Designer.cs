namespace Form5_04
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnUCLN = new System.Windows.Forms.Button();
            this.btnBCNN = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết quả";
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(200, 82);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(235, 34);
            this.txtSo1.TabIndex = 1;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(200, 154);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(235, 34);
            this.txtSo2.TabIndex = 1;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(200, 228);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(235, 34);
            this.txtKetQua.TabIndex = 1;
            // 
            // btnUCLN
            // 
            this.btnUCLN.Location = new System.Drawing.Point(484, 82);
            this.btnUCLN.Name = "btnUCLN";
            this.btnUCLN.Size = new System.Drawing.Size(118, 32);
            this.btnUCLN.TabIndex = 2;
            this.btnUCLN.Text = "USC LN";
            this.btnUCLN.UseVisualStyleBackColor = true;
            this.btnUCLN.Click += new System.EventHandler(this.btnUCLN_Click);
            // 
            // btnBCNN
            // 
            this.btnBCNN.Location = new System.Drawing.Point(484, 154);
            this.btnBCNN.Name = "btnBCNN";
            this.btnBCNN.Size = new System.Drawing.Size(118, 32);
            this.btnBCNN.TabIndex = 2;
            this.btnBCNN.Text = "BSC NN";
            this.btnBCNN.UseVisualStyleBackColor = true;
            this.btnBCNN.Click += new System.EventHandler(this.btnBCNN_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(484, 228);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 32);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 332);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBCNN);
            this.Controls.Add(this.btnUCLN);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Ước số chung - Bội số chung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnUCLN;
        private System.Windows.Forms.Button btnBCNN;
        private System.Windows.Forms.Button btnThoat;
    }
}

