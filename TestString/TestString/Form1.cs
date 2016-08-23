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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPhanTich_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            if (!string.IsNullOrEmpty(txtChuoiSo.Text))
            {
                string s = txtChuoiSo.Text;

                // tach mang ky tu
                char[] s_array = s.ToArray();
                
                // dem so lan ky tu xuat hien trong mang
                foreach (var c in s_array)
                {
                    if (result.ContainsKey(c.ToString()))
                    {
                        result[c.ToString()] += 1;
                    }
                    else
                    {
                        result.Add(c.ToString(), 1);
                    }
                }


                // hien thi ket qua
                txtResult.Clear();
                foreach (var d in result.OrderByDescending(o => o.Value))
                { 
                    txtResult.AppendText(d.Key + " - " + d.Value + "\r\n");
                }
            }



            txtResult.AppendText(RandomStringNumber(5,false) + "\r\n");
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

        private void btnChecking_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> dic1 = new Dictionary<int, string>();
            Dictionary<int, string> dic2 = new Dictionary<int, string>();
            Dictionary<int, string> dic3 = new Dictionary<int, string>();
            Dictionary<int, string> dicDau = new Dictionary<int, string>();
            Dictionary<int, string> dicDuoi = new Dictionary<int, string>();
            Dictionary<int, string> dicDau1 = new Dictionary<int, string>();
            Dictionary<int, string> dicDuoi1 = new Dictionary<int, string>();
            Dictionary<int, string> dicDauResult = new Dictionary<int, string>();
            Dictionary<int, string> dicDuoiResult = new Dictionary<int, string>();

            if (!string.IsNullOrEmpty(txtNgay1.Text) && !string.IsNullOrEmpty(txtNgay2.Text))
            {
                string s1 = txtNgay1.Text;
                string s2 = txtNgay2.Text;
                string s3 = txtNgay3.Text;
                string s_dau1 = txtNgay1.Text.Substring(3, 1);
                string s_duoi1 = txtNgay1.Text.Substring(4, 1);
                string s_dau2 = txtNgay2.Text.Substring(3, 1);
                string s_duoi2 = txtNgay2.Text.Substring(4, 1);    

                // tach mang ky tu
                char[] s_array_1 = s1.ToArray();
                char[] s_array_2 = s2.ToArray();
                char[] s_array_3 = s3.ToArray();

                // dua vao dic
                for (var i = 0; i < s_array_1.Length; i++)
                {
                    dic1.Add(i, s_array_1[i].ToString());
                }

                for (var j = 0; j < s_array_2.Length; j++)
                {
                    dic2.Add(j, s_array_2[j].ToString());
                }

                for (var k = 0; k < s_array_3.Length; k++)
                {
                    dic3.Add(k, s_array_3[k].ToString());
                }

                // so sanh
                foreach (var s in dic3)
                {
                    if (s.Value == s_dau2)
                    {
                        dicDau.Add(s.Key, s.Value);
                    }

                    if (s.Value == s_duoi2)
                    {
                        dicDuoi.Add(s.Key, s.Value);
                    }
                }


                foreach (var s in dic2)
                {
                    if (s.Value == s_dau1)
                    {
                        dicDau1.Add(s.Key, s.Value);
                    }

                    if (s.Value == s_duoi1)
                    {
                        dicDuoi1.Add(s.Key, s.Value);
                    }
                }


                foreach (var kq in dicDau1)
                {
                    if (dicDau.ContainsKey(kq.Key)) dicDauResult.Add(kq.Key, kq.Value);
                }

                foreach (var kq in dicDuoi1)
                {
                    if (dicDuoi.ContainsKey(kq.Key)) dicDuoiResult.Add(kq.Key, kq.Value);
                }

                // hien thi ket qua
                txtDau.Clear();
                foreach (var d in dicDauResult)
                {
                    txtDau.AppendText((d.Key+1) + " - " + dic1[d.Key] + "\r\n");
                }

                txtDuoi.Clear();
                foreach (var d in dicDuoiResult)
                {
                    txtDuoi.AppendText((d.Key + 1) + " - " + dic1[d.Key] + "\r\n");
                }
            }
        }
    }
}
