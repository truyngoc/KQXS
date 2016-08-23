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
    public partial class frmLoGan : Form
    {
        public frmLoGan()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            // trong danh sach so 01 -> 99
            // tim tu ngay, den ngay
            // neu ngay nao ko xuat hien thi +1 -> cho den ngay xuat hien gan nhat
            List<LoGan> lstLoGan = new List<LoGan>();

            lstLoGan = Statistics_LoGan();

            var lstLoGanOrder = lstLoGan.OrderByDescending(o => o.So_Ngay_Gan);
            dgvLoGan.DataSource = lstLoGanOrder.ToList();

            dgvLoGanOrder.DataSource = lstLoGan;
        }

        private List<string> CreateDialNumber()
        {
            List<string> dialNumber = new List<string>();

            for (var i = 0; i < 100; i++)
            {
                dialNumber.Add(i.ToString().PadLeft(2,'0'));
            }

            return dialNumber;
        }

        private List<LoGan> Statistics_LoGan()
        {
            XSMBContext db = new XSMBContext();

            var tu_ngay = dtpNgayBatDau.Value.Date;
            var den_ngay = dtpNgayKetThuc.Value.Date;

            var lstKQ = db.KetQuaMB.Where(o => o.Ngay_Quay >= tu_ngay && o.Ngay_Quay <= den_ngay).OrderByDescending(s => s.Ngay_Quay);


            var lstNum = CreateDialNumber();

            // trong danh sach so 01 -> 99
            // tim tu ngay, den ngay
            // neu ngay nao ko xuat hien thi +1 -> cho den ngay xuat hien gan nhat
            List<LoGan> lstLoGan = new List<LoGan>();

            foreach (var num in lstNum)
            {
                DateTime? date_occur = null;
                var lstMatch = lstKQ.Where(x => x.Ket_Qua.EndsWith(num));

                if (lstMatch != null && lstMatch.Count() > 0)
                {
                    date_occur = lstMatch.First().Ngay_Quay;
                }

                LoGan lg = new LoGan();
                lg.So = num;

                if (date_occur.HasValue)
                {
                    DateTime date_conv = date_occur ?? DateTime.Today;

                    lg.Ngay_Ra_Gan_Nhat = date_conv;
                    lg.So_Ngay_Gan = (DateTime.Today.AddDays(-1) - date_conv).Days;
                }

                lstLoGan.Add(lg);

            }

            return lstLoGan;
        }
    }


    class LoGan
    {
        public string So { get; set; }
        public DateTime? Ngay_Ra_Gan_Nhat { get; set; }
        public int So_Ngay_Gan { get; set; }
    }
}
