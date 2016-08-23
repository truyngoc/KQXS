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
    public partial class frmLucky : Form
    {
        public frmLucky()
        {
            InitializeComponent();
        }

        private void btnLuck_Click(object sender, EventArgs e)
        {
            // progress bar
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 0;

            backgroundWorker1.RunWorkerAsync();            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {                
                int times = Convert.ToInt32(txtSoLan.Text);
                Dictionary<string, int> dicNum = CreateDialNumber();


                for (var i = 0; i < times; i++)
                {
                    var rdNumber = RandomStringNumber(5, false);
                    var specialNumber = SplitSpecialAdwards(rdNumber);

                    if (dicNum.ContainsKey(specialNumber))
                    {
                        dicNum[specialNumber] += 1;
                    }

                    backgroundWorker1.ReportProgress(
                                                    ((i == 0 ? 1 : i) * 100) / (times == 0 ? 1 : times));  // tinh % cua progress bar
                }

                foreach (var d in dicNum)
                {
                    this.AppendTextBox(d.Key + "\t" + d.Value + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Xong rồi đấy!");
        }


        private Dictionary<string,int> CreateDialNumber()
        {
            Dictionary<string, int> dialNumber = new Dictionary<string, int>();

            for (var i = 0; i < 100; i++)
            {
                dialNumber.Add(i.ToString().PadLeft(2, '0'),0);
            }

            return dialNumber;
        }

        private string RandomStringNumber(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                builder.Append(random.Next(0, 10).ToString());
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        private string SplitSpecialAdwards(string number)
        {
            var s = number.Substring(3, 2);

            return s;
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            txtResult.AppendText(value);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

    }
}
