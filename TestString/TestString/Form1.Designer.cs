namespace TestString
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
            this.txtChuoiSo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPhanTich = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtNgay1 = new System.Windows.Forms.TextBox();
            this.txtNgay2 = new System.Windows.Forms.TextBox();
            this.btnChecking = new System.Windows.Forms.Button();
            this.txtDau = new System.Windows.Forms.TextBox();
            this.txtDuoi = new System.Windows.Forms.TextBox();
            this.txtNgay3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtChuoiSo
            // 
            this.txtChuoiSo.Location = new System.Drawing.Point(12, 48);
            this.txtChuoiSo.Multiline = true;
            this.txtChuoiSo.Name = "txtChuoiSo";
            this.txtChuoiSo.Size = new System.Drawing.Size(235, 242);
            this.txtChuoiSo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chuỗi số";
            // 
            // btnPhanTich
            // 
            this.btnPhanTich.Location = new System.Drawing.Point(12, 304);
            this.btnPhanTich.Name = "btnPhanTich";
            this.btnPhanTich.Size = new System.Drawing.Size(75, 23);
            this.btnPhanTich.TabIndex = 2;
            this.btnPhanTich.Text = "Đếm";
            this.btnPhanTich.UseVisualStyleBackColor = true;
            this.btnPhanTich.Click += new System.EventHandler(this.btnPhanTich_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(253, 48);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(149, 242);
            this.txtResult.TabIndex = 3;
            // 
            // txtNgay1
            // 
            this.txtNgay1.Location = new System.Drawing.Point(439, 48);
            this.txtNgay1.Multiline = true;
            this.txtNgay1.Name = "txtNgay1";
            this.txtNgay1.Size = new System.Drawing.Size(235, 107);
            this.txtNgay1.TabIndex = 4;
            this.txtNgay1.Text = "627524025863813665698261502000172672872209979845660739029303479485833151247438754" +
    "15045648100075597686960328";
            // 
            // txtNgay2
            // 
            this.txtNgay2.Location = new System.Drawing.Point(439, 161);
            this.txtNgay2.Multiline = true;
            this.txtNgay2.Name = "txtNgay2";
            this.txtNgay2.Size = new System.Drawing.Size(235, 107);
            this.txtNgay2.TabIndex = 5;
            this.txtNgay2.Text = "342066087422988238859338227905225861280878622421395051709022574542755302765736318" +
    "91802216427739600941800960";
            // 
            // btnChecking
            // 
            this.btnChecking.Location = new System.Drawing.Point(439, 406);
            this.btnChecking.Name = "btnChecking";
            this.btnChecking.Size = new System.Drawing.Size(75, 23);
            this.btnChecking.TabIndex = 6;
            this.btnChecking.Text = "Phân tích";
            this.btnChecking.UseVisualStyleBackColor = true;
            this.btnChecking.Click += new System.EventHandler(this.btnChecking_Click);
            // 
            // txtDau
            // 
            this.txtDau.Location = new System.Drawing.Point(680, 48);
            this.txtDau.Multiline = true;
            this.txtDau.Name = "txtDau";
            this.txtDau.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDau.Size = new System.Drawing.Size(149, 242);
            this.txtDau.TabIndex = 7;
            // 
            // txtDuoi
            // 
            this.txtDuoi.Location = new System.Drawing.Point(835, 48);
            this.txtDuoi.Multiline = true;
            this.txtDuoi.Name = "txtDuoi";
            this.txtDuoi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDuoi.Size = new System.Drawing.Size(149, 242);
            this.txtDuoi.TabIndex = 8;
            // 
            // txtNgay3
            // 
            this.txtNgay3.Location = new System.Drawing.Point(439, 274);
            this.txtNgay3.Multiline = true;
            this.txtNgay3.Name = "txtNgay3";
            this.txtNgay3.Size = new System.Drawing.Size(235, 107);
            this.txtNgay3.TabIndex = 9;
            this.txtNgay3.Text = "510928074732017646973065916262868096758937996671938195091645038693003095984998608" +
    "37866515915702807347246054";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 551);
            this.Controls.Add(this.txtNgay3);
            this.Controls.Add(this.txtDuoi);
            this.Controls.Add(this.txtDau);
            this.Controls.Add(this.btnChecking);
            this.Controls.Add(this.txtNgay2);
            this.Controls.Add(this.txtNgay1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnPhanTich);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChuoiSo);
            this.Name = "Form1";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChuoiSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPhanTich;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtNgay1;
        private System.Windows.Forms.TextBox txtNgay2;
        private System.Windows.Forms.Button btnChecking;
        private System.Windows.Forms.TextBox txtDau;
        private System.Windows.Forms.TextBox txtDuoi;
        private System.Windows.Forms.TextBox txtNgay3;
    }
}

