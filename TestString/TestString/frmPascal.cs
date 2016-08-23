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
    public partial class frmPascal : Form
    {
        public frmPascal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var so_can_tinh = txtSoThu1.Text + txtSoThu2.Text;
            string kq = string.Empty;

            // tinh theo thuat tuan Pascal
            if (!string.IsNullOrEmpty(so_can_tinh)) 
            {
                kq = calcPascal(so_can_tinh);
            } 

            // dua ra kq
            txtPascalResult.Text = kq;


            // quy luat ngu hanh
            // Kim -> Thuy -> Moc -> Hoa -> Tho -> Kim
            // 4,9 -> 1,6 -> 3,8 -> 2,7 -> 5, 0 -> 4,9           
            // 4 -> 1 -> 3 -> 2 -> 0 -> 4
            // 9 -> 6 -> 8 -> 7 -> 5 -> 9
            var dac_biet = txtSoThu1.Text.Substring(3,2);
            char[] db = dac_biet.ToArray();
            Dictionary<string, string> ngu_hanh = new Dictionary<string, string>() {
                {"4","1"},
                {"1","3"},
                {"3","2"},
                {"2","0"},
                {"0","4"},
                {"9","6"},
                {"6","8"},
                {"8","7"},
                {"7","5"},
                {"5","9"},
            };

            string result_NguHanh = "";
            foreach (var c in db)
            {
                result_NguHanh += ngu_hanh[c.ToString()].ToString();
            }

            txtNguHanh.Text = result_NguHanh;

             //Tiền đề Âm dương Ngũ hành của hệ thập phân trong cấu trúc số
             //   + Thiên nhất sinh Thuỷ, Địa lục thành chi
             //   + Địa nhị sinh Hỏa, Thiên thất thành chi 
             //   + Thiên tam sinh Mộc, Địa bát thành chi 
             //   + Địa tứ sinh Kim, Thiên cửu thành chi 
             //   + Thiên ngũ sinh Thổ, Địa thập thành chi
 
             //   + Trời lấy số 1 mà khởi sinh hành Thuỷ, Đất lấy số 6 mà tạo thành hành Thuỷ 
             //   + Đất lấy số 2 mà khởi sinh hành Hỏa, Trời lấy số 7 mà tạo thành hành Hỏa 
             //   + Trời lấy số 3 mà khởi sinh hành Mộc, Đất lấy số 8 mà tạo thành hành Mộc 
             //   + Đất lấy số 4 mà khởi sinh hành Kim, Trời lấy số 9 mà tạo thành hành Kim 
             //   + Trời lấy số 5 mà khởi sinh hành Thổ, Đất lấy số 10 mà tạo thành hành Thổ 
             //   + Các số lẻ 1,3,5,7,9 gọi là số của Trời, số Dương hay số Cơ, trong đó 1,3,5 là số Sinh của Trời, 7,9 gọi là số Thành của Trời. 
             //   + Các số chẵn 2,4,6,8,10 gọi là số của Đất, số Âm hay số Ngẫu, trong đó 2,4 gọi là số Sinh của Đất, còn 6,8,10 gọi là số Thành của Đất. 
             
            //   - Nguyên lý Âm dương Ngũ hành của hệ thập phân trong cấu trúc số 
             //   + Số 1 có tính chất là Dương thủy, số 6 có tính chất là Âm thuỷ 
             //   + Số 2 có tính chất là Âm hỏa, số 7 có tính chất là Dương hỏa 
             //   + Số 3 có tính chất là Dương mộc, số 8 có tính chất là Âm mộc 
             //   + Số 4 có tính chất là Âm kim, số 9 có tính chất là Dương kim 
             //   + Số 5 có tính chất là Dương thổ, số 10 có tính chất là Âm thổ
        }

        private string calcPascal(string so)
        {
            char[] num = so.ToArray();
            string result = string.Empty;

            for (var i = 0; i < num.Length - 1; i++)
            {
                int p = Convert.ToInt32(num[i].ToString()) 
                        + Convert.ToInt32(num[i + 1].ToString());

                int phan_du = p % 10;

                result += phan_du.ToString();
            }

            if (result.Length == 2)
                return result;
            else
                return calcPascal(result);
        }
    }
}
