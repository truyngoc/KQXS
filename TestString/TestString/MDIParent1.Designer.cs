namespace TestString
{
    partial class MDIParent1
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.countCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layKetQuaMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pascalMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loganMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dacbietMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.luckMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countCharactersToolStripMenuItem,
            this.layKetQuaMnuItem,
            this.pascalMnuItem,
            this.loganMnuItem,
            this.dacbietMnuItem,
            this.luckMnuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(50, 20);
            this.helpMenu.Text = "Menu";
            // 
            // countCharactersToolStripMenuItem
            // 
            this.countCharactersToolStripMenuItem.Name = "countCharactersToolStripMenuItem";
            this.countCharactersToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.countCharactersToolStripMenuItem.Text = "Số lần ký tự xuất hiện";
            this.countCharactersToolStripMenuItem.Click += new System.EventHandler(this.countCharactersToolStripMenuItem_Click);
            // 
            // layKetQuaMnuItem
            // 
            this.layKetQuaMnuItem.Name = "layKetQuaMnuItem";
            this.layKetQuaMnuItem.Size = new System.Drawing.Size(186, 22);
            this.layKetQuaMnuItem.Text = "Lấy kết quả tự động";
            this.layKetQuaMnuItem.Click += new System.EventHandler(this.layKetQuaMnuItem_Click);
            // 
            // pascalMnuItem
            // 
            this.pascalMnuItem.Name = "pascalMnuItem";
            this.pascalMnuItem.Size = new System.Drawing.Size(186, 22);
            this.pascalMnuItem.Text = "Tính theo Pascal";
            this.pascalMnuItem.Click += new System.EventHandler(this.pascalMnuItem_Click);
            // 
            // loganMnuItem
            // 
            this.loganMnuItem.Name = "loganMnuItem";
            this.loganMnuItem.Size = new System.Drawing.Size(186, 22);
            this.loganMnuItem.Text = "Lô gan";
            this.loganMnuItem.Click += new System.EventHandler(this.loganMnuItem_Click);
            // 
            // dacbietMnuItem
            // 
            this.dacbietMnuItem.Name = "dacbietMnuItem";
            this.dacbietMnuItem.Size = new System.Drawing.Size(186, 22);
            this.dacbietMnuItem.Text = "Đặc biệt";
            this.dacbietMnuItem.Click += new System.EventHandler(this.dacbietMnuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // luckMnuItem
            // 
            this.luckMnuItem.Name = "luckMnuItem";
            this.luckMnuItem.Size = new System.Drawing.Size(186, 22);
            this.luckMnuItem.Text = "Luck";
            this.luckMnuItem.Click += new System.EventHandler(this.luckMnuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "North Lottery";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem countCharactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layKetQuaMnuItem;
        private System.Windows.Forms.ToolStripMenuItem pascalMnuItem;
        private System.Windows.Forms.ToolStripMenuItem loganMnuItem;
        private System.Windows.Forms.ToolStripMenuItem dacbietMnuItem;
        private System.Windows.Forms.ToolStripMenuItem luckMnuItem;
    }
}



