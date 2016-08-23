namespace TestString
{
    partial class frmLucky
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
            this.btnLuck = new System.Windows.Forms.Button();
            this.txtSoLan = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLuck
            // 
            this.btnLuck.Location = new System.Drawing.Point(22, 12);
            this.btnLuck.Name = "btnLuck";
            this.btnLuck.Size = new System.Drawing.Size(75, 23);
            this.btnLuck.TabIndex = 0;
            this.btnLuck.Text = "Start Luck";
            this.btnLuck.UseVisualStyleBackColor = true;
            this.btnLuck.Click += new System.EventHandler(this.btnLuck_Click);
            // 
            // txtSoLan
            // 
            this.txtSoLan.Location = new System.Drawing.Point(190, 12);
            this.txtSoLan.Name = "txtSoLan";
            this.txtSoLan.Size = new System.Drawing.Size(100, 20);
            this.txtSoLan.TabIndex = 1;
            this.txtSoLan.Text = "1000000";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(22, 54);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(268, 340);
            this.txtResult.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 400);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(309, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(103, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmLucky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 423);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSoLan);
            this.Controls.Add(this.btnLuck);
            this.Name = "frmLucky";
            this.Text = "Luck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuck;
        private System.Windows.Forms.TextBox txtSoLan;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnClear;
    }
}