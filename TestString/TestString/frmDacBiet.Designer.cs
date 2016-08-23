namespace TestString
{
    partial class frmDacBiet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dgvKetQuaAfter = new System.Windows.Forms.DataGridView();
            this.txtSoDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvKetQuaBefore = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayQuay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCauDe = new System.Windows.Forms.Button();
            this.txtDau = new System.Windows.Forms.TextBox();
            this.txtDuoi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Biên ngày";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(144, 22);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(111, 20);
            this.dtpNgayBatDau.TabIndex = 6;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(29, 156);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 8;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dgvKetQuaAfter
            // 
            this.dgvKetQuaAfter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKetQuaAfter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQuaAfter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNgayQuay,
            this.colKetQua});
            this.dgvKetQuaAfter.Location = new System.Drawing.Point(825, 0);
            this.dgvKetQuaAfter.Name = "dgvKetQuaAfter";
            this.dgvKetQuaAfter.Size = new System.Drawing.Size(275, 432);
            this.dgvKetQuaAfter.TabIndex = 9;
            // 
            // txtSoDB
            // 
            this.txtSoDB.Location = new System.Drawing.Point(144, 48);
            this.txtSoDB.Name = "txtSoDB";
            this.txtSoDB.Size = new System.Drawing.Size(111, 20);
            this.txtSoDB.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Số ĐB";
            // 
            // dgvKetQuaBefore
            // 
            this.dgvKetQuaBefore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKetQuaBefore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQuaBefore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvKetQuaBefore.Location = new System.Drawing.Point(268, 0);
            this.dgvKetQuaBefore.Name = "dgvKetQuaBefore";
            this.dgvKetQuaBefore.Size = new System.Drawing.Size(281, 432);
            this.dgvKetQuaBefore.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.Location = new System.Drawing.Point(549, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(276, 432);
            this.dataGridView1.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ngay_Quay";
            dataGridViewCellStyle7.Format = "dd/MM/yyyy";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn1.HeaderText = "Ngày quay trước";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Giai_DB";
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Blue;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn2.HeaderText = "Kết quả";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ngay_Quay";
            dataGridViewCellStyle9.Format = "dd/MM/yyyy";
            dataGridViewCellStyle9.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày quay";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Giai_DB";
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Blue;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn4.HeaderText = "Kết quả";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // colNgayQuay
            // 
            this.colNgayQuay.DataPropertyName = "Ngay_Quay";
            dataGridViewCellStyle11.Format = "dd/MM/yyyy";
            dataGridViewCellStyle11.NullValue = null;
            this.colNgayQuay.DefaultCellStyle = dataGridViewCellStyle11;
            this.colNgayQuay.HeaderText = "Ngày quay sau";
            this.colNgayQuay.Name = "colNgayQuay";
            this.colNgayQuay.Width = 120;
            // 
            // colKetQua
            // 
            this.colKetQua.DataPropertyName = "Giai_DB";
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Blue;
            this.colKetQua.DefaultCellStyle = dataGridViewCellStyle12;
            this.colKetQua.HeaderText = "Kết quả";
            this.colKetQua.Name = "colKetQua";
            // 
            // btnCauDe
            // 
            this.btnCauDe.Location = new System.Drawing.Point(29, 199);
            this.btnCauDe.Name = "btnCauDe";
            this.btnCauDe.Size = new System.Drawing.Size(75, 23);
            this.btnCauDe.TabIndex = 16;
            this.btnCauDe.Text = "Cầu đề";
            this.btnCauDe.UseVisualStyleBackColor = true;
            this.btnCauDe.Click += new System.EventHandler(this.btnCauDe_Click);
            // 
            // txtDau
            // 
            this.txtDau.Location = new System.Drawing.Point(268, 438);
            this.txtDau.Multiline = true;
            this.txtDau.Name = "txtDau";
            this.txtDau.Size = new System.Drawing.Size(433, 98);
            this.txtDau.TabIndex = 17;
            // 
            // txtDuoi
            // 
            this.txtDuoi.Location = new System.Drawing.Point(707, 438);
            this.txtDuoi.Multiline = true;
            this.txtDuoi.Name = "txtDuoi";
            this.txtDuoi.Size = new System.Drawing.Size(393, 98);
            this.txtDuoi.TabIndex = 18;
            // 
            // frmDacBiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 537);
            this.Controls.Add(this.txtDuoi);
            this.Controls.Add(this.txtDau);
            this.Controls.Add(this.btnCauDe);
            this.Controls.Add(this.dgvKetQuaBefore);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoDB);
            this.Controls.Add(this.dgvKetQuaAfter);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Name = "frmDacBiet";
            this.Text = "Thống kê số giải ĐB";
            this.Load += new System.EventHandler(this.frmDacBiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DataGridView dgvKetQuaAfter;
        private System.Windows.Forms.TextBox txtSoDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvKetQuaBefore;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayQuay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnCauDe;
        private System.Windows.Forms.TextBox txtDau;
        private System.Windows.Forms.TextBox txtDuoi;
    }
}