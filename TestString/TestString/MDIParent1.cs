using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestString
{
    public partial class MDIParent1 : Form
    {        
        public MDIParent1()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }

        private void countCharactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.MdiParent = this;
            frm1.WindowState = FormWindowState.Normal;
            frm1.Show();
        }

        private void layKetQuaMnuItem_Click(object sender, EventArgs e)
        {
            frmLayKetQua frmLayKQ = new frmLayKetQua();
            frmLayKQ.MdiParent = this;
            frmLayKQ.WindowState = FormWindowState.Normal;
            frmLayKQ.Show();
        }

        private void pascalMnuItem_Click(object sender, EventArgs e)
        {
            frmPascal frPascal = new frmPascal();
            frPascal.MdiParent = this;
            frPascal.WindowState = FormWindowState.Normal;
            frPascal.Show();
        }

        private void loganMnuItem_Click(object sender, EventArgs e)
        {
            frmLoGan frmLoGan = new frmLoGan();
            frmLoGan.MdiParent = this;
            frmLoGan.WindowState = FormWindowState.Maximized;
            frmLoGan.Show();
        }

        private void dacbietMnuItem_Click(object sender, EventArgs e)
        {
            frmDacBiet frm = new frmDacBiet();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void luckMnuItem_Click(object sender, EventArgs e)
        {
            frmLucky frm = new frmLucky();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }
      
    }
}
