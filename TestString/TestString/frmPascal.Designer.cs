namespace TestString
{
    partial class frmPascal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoThu1 = new System.Windows.Forms.TextBox();
            this.txtSoThu2 = new System.Windows.Forms.TextBox();
            this.btnPascal = new System.Windows.Forms.Button();
            this.txtPascalResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNguHanh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giải nhất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải ĐB";
            // 
            // txtSoThu1
            // 
            this.txtSoThu1.Location = new System.Drawing.Point(133, 39);
            this.txtSoThu1.Name = "txtSoThu1";
            this.txtSoThu1.Size = new System.Drawing.Size(134, 20);
            this.txtSoThu1.TabIndex = 1;
            // 
            // txtSoThu2
            // 
            this.txtSoThu2.Location = new System.Drawing.Point(133, 70);
            this.txtSoThu2.Name = "txtSoThu2";
            this.txtSoThu2.Size = new System.Drawing.Size(134, 20);
            this.txtSoThu2.TabIndex = 3;
            // 
            // btnPascal
            // 
            this.btnPascal.Location = new System.Drawing.Point(133, 106);
            this.btnPascal.Name = "btnPascal";
            this.btnPascal.Size = new System.Drawing.Size(134, 23);
            this.btnPascal.TabIndex = 4;
            this.btnPascal.Text = "Tính theo Pascal";
            this.btnPascal.UseVisualStyleBackColor = true;
            this.btnPascal.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPascalResult
            // 
            this.txtPascalResult.Location = new System.Drawing.Point(133, 149);
            this.txtPascalResult.Name = "txtPascalResult";
            this.txtPascalResult.Size = new System.Drawing.Size(134, 20);
            this.txtPascalResult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pascal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngũ hành";
            // 
            // txtNguHanh
            // 
            this.txtNguHanh.Location = new System.Drawing.Point(133, 179);
            this.txtNguHanh.Name = "txtNguHanh";
            this.txtNguHanh.Size = new System.Drawing.Size(134, 20);
            this.txtNguHanh.TabIndex = 7;
            // 
            // frmPascal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 220);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNguHanh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPascalResult);
            this.Controls.Add(this.btnPascal);
            this.Controls.Add(this.txtSoThu2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoThu1);
            this.Controls.Add(this.label1);
            this.Name = "frmPascal";
            this.Text = "Tính cầu theo quy luật Pascal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoThu1;
        private System.Windows.Forms.TextBox txtSoThu2;
        private System.Windows.Forms.Button btnPascal;
        private System.Windows.Forms.TextBox txtPascalResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNguHanh;
    }
}