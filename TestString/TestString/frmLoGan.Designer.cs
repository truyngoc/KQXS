namespace TestString
{
    partial class frmLoGan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dgvLoGan = new System.Windows.Forms.DataGridView();
            this.dgvLoGanOrder = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayRaGanNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSo_Ngay_gan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoGan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoGanOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(135, 107);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(135, 66);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(111, 20);
            this.dtpNgayKetThuc.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ ngày";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(135, 12);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(111, 20);
            this.dtpNgayBatDau.TabIndex = 4;
            // 
            // dgvLoGan
            // 
            this.dgvLoGan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoGan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSo,
            this.colNgayRaGanNhat,
            this.colSo_Ngay_gan});
            this.dgvLoGan.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvLoGan.Location = new System.Drawing.Point(639, 0);
            this.dgvLoGan.Name = "dgvLoGan";
            this.dgvLoGan.Size = new System.Drawing.Size(385, 465);
            this.dgvLoGan.TabIndex = 8;
            // 
            // dgvLoGanOrder
            // 
            this.dgvLoGanOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoGanOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvLoGanOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvLoGanOrder.Location = new System.Drawing.Point(254, 0);
            this.dgvLoGanOrder.Name = "dgvLoGanOrder";
            this.dgvLoGanOrder.Size = new System.Drawing.Size(385, 465);
            this.dgvLoGanOrder.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "So";
            this.dataGridViewTextBoxColumn1.HeaderText = "Số";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ngay_Ra_Gan_Nhat";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "Ngày ra gần nhất";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "So_Ngay_Gan";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn3.HeaderText = "Số ngày gan";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // colSo
            // 
            this.colSo.DataPropertyName = "So";
            this.colSo.HeaderText = "Số";
            this.colSo.Name = "colSo";
            this.colSo.ReadOnly = true;
            this.colSo.Width = 80;
            // 
            // colNgayRaGanNhat
            // 
            this.colNgayRaGanNhat.DataPropertyName = "Ngay_Ra_Gan_Nhat";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.colNgayRaGanNhat.DefaultCellStyle = dataGridViewCellStyle1;
            this.colNgayRaGanNhat.HeaderText = "Ngày ra gần nhất";
            this.colNgayRaGanNhat.Name = "colNgayRaGanNhat";
            this.colNgayRaGanNhat.ReadOnly = true;
            this.colNgayRaGanNhat.Width = 150;
            // 
            // colSo_Ngay_gan
            // 
            this.colSo_Ngay_gan.DataPropertyName = "So_Ngay_Gan";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.colSo_Ngay_gan.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSo_Ngay_gan.HeaderText = "Số ngày gan";
            this.colSo_Ngay_gan.Name = "colSo_Ngay_gan";
            this.colSo_Ngay_gan.ReadOnly = true;
            this.colSo_Ngay_gan.Width = 80;
            // 
            // frmLoGan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 465);
            this.Controls.Add(this.dgvLoGanOrder);
            this.Controls.Add(this.dgvLoGan);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.btnThongKe);
            this.Name = "frmLoGan";
            this.Text = "Thống kê lô gan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoGan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoGanOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DataGridView dgvLoGan;
        private System.Windows.Forms.DataGridView dgvLoGanOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayRaGanNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSo_Ngay_gan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}