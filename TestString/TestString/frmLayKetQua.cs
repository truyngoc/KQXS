using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// su dung HtmlAgilityPack de parser HTML
// http://www.mikesdotnetting.com/article/273/using-the-htmlagilitypack-to-parse-html-in-asp-net
// http://www.c-sharpcorner.com/UploadFile/9b86d4/getting-started-with-html-agility-pack/

using HtmlAgilityPack;

namespace TestString
{
    public partial class frmLayKetQua : Form
    {
        public frmLayKetQua()
        {
            InitializeComponent();
        }

        private void btnLayKetQua_Click(object sender, EventArgs e)
        {
            int day = (dtpNgayKetThuc.Value - dtpNgayBatDau.Value).Days;

            // progress bar
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 0;

            backgroundWorker1.RunWorkerAsync();
        }


        private string TaoLink(DateTime date)
        {
            // link lay ket qua
            string fixed_link = "http://www.minhngoc.net.vn/ket-qua-xo-so/mien-bac/";

            // dinh dang ngay lay ket qua
            var stringDate = string.Format("{0:dd-MM-yyyy}", date);

            // tao link
            var link = fixed_link + stringDate + ".html";

            return link;
        }


        private KetQuaMB_Flat KetQua_MB_Flat(List<KetQuaMB> lstKQ, DateTime ngayKQ)
        {
            KetQuaMB_Flat kq = new KetQuaMB_Flat();


            kq.Ngay_Quay = ngayKQ;

            foreach (var o in lstKQ)
            {                
                switch (o.Ma_Giai)
                { 
                    case "giaidb":
                        kq.Giai_DB = o.Ket_Qua;
                        break;
                    case "giai1":
                        kq.Giai_1 = o.Ket_Qua;
                        break;
                    case "giai2":
                        if (string.IsNullOrEmpty(kq.Giai_21))
                        {
                            kq.Giai_21 = o.Ket_Qua;
                        }
                        else if (string.IsNullOrEmpty(kq.Giai_22))
                        {
                            kq.Giai_22 = o.Ket_Qua;
                        }
                        break;
                    case "giai3":
                        if (string.IsNullOrEmpty(kq.Giai_31))
                        {
                            kq.Giai_31 = o.Ket_Qua;
                        }
                        else if (string.IsNullOrEmpty(kq.Giai_32))
                        {
                            kq.Giai_32 = o.Ket_Qua;
                        }
                        else if (string.IsNullOrEmpty(kq.Giai_33))
                        {
                            kq.Giai_33 = o.Ket_Qua;
                        }
                        else if (string.IsNullOrEmpty(kq.Giai_34))
                        {
                            kq.Giai_34 = o.Ket_Qua;
                        }
                        else if (string.IsNullOrEmpty(kq.Giai_35))
                        {
                            kq.Giai_35 = o.Ket_Qua;
                        }
                        else if (string.IsNullOrEmpty(kq.Giai_36))
                        {
                            kq.Giai_36 = o.Ket_Qua;
                        }
                        break;
                    case "giai4":
                        if (string.IsNullOrEmpty(kq.Giai_41))
                        {
                            kq.Giai_41 = o.Ket_Qua;
                        }
                        else if (string.IsNullOrEmpty(kq.Giai_42))
                        {
                            kq.Giai_42 = o.Ket_Qua;
                        }
                        else if (string.IsNullOrEmpty(kq.Giai_43))
                        {
                            kq.Giai_43 = o.Ket_Qua;
                        }
                        else if (string.IsNullOrEmpty(kq.Giai_44))
                        {
                            kq.Giai_44 = o.Ket_Qua;
                        }
                        break;
                    case "giai5":
                        if (string.IsNullOrEmpty(kq.Giai_51))
                        {
                            kq.Giai_51 = o.Ket_Qua;
                        }
                        else if (string.IsNullOrEmpty(kq.Giai_52))
                        {
                            kq.Giai_52 = o.Ket_Qua;
                        }
                        else if (string.IsNullOrEmpty(kq.Giai_53))
                        {
                            kq.Giai_53 = o.Ket_Qua;
                        }
                        else if (string.IsNullOrEmpty(kq.Giai_54))
                        {
                            kq.Giai_54 = o.Ket_Qua;
                        }
                        else if (string.IsNullOrEmpty(kq.Giai_55))
                        {
                            kq.Giai_55 = o.Ket_Qua;
                        }
                        else if (string.IsNullOrEmpty(kq.Giai_56))
                        {
                            kq.Giai_56 = o.Ket_Qua;
                        }
                        break;
                    case "giai6":
                        if (string.IsNullOrEmpty(kq.Giai_61))
                        {
                            kq.Giai_61 = o.Ket_Qua;
                        }
                        else if (string.IsNullOrEmpty(kq.Giai_62))
                        {
                            kq.Giai_62 = o.Ket_Qua;
                        }
                        else if (string.IsNullOrEmpty(kq.Giai_63))
                        {
                            kq.Giai_63 = o.Ket_Qua;
                        }
                        break;
                    case "giai7":
                        if (string.IsNullOrEmpty(kq.Giai_71))
                        {
                            kq.Giai_71 = o.Ket_Qua;
                        }
                        else if (string.IsNullOrEmpty(kq.Giai_72))
                        {
                            kq.Giai_72 = o.Ket_Qua;
                        }
                        else if (string.IsNullOrEmpty(kq.Giai_73))
                        {
                            kq.Giai_73 = o.Ket_Qua;
                        }
                        else if (string.IsNullOrEmpty(kq.Giai_74))
                        {
                            kq.Giai_74 = o.Ket_Qua;
                        }
                        break;
                }
            }

            return kq;
        }

        private void LayKetQua(DateTime ngaylaykq)
        {
            XSMBContext db = new XSMBContext();

            //if (db.KetQuaMB_Flat.Where(o => o.Ngay_Quay == ngaylaykq).Count() > 0) return;


            string link = string.Empty;
            string[] giai = { "giaidb", "giai1", "giai2", "giai3", "giai4", "giai5", "giai6", "giai7" };
            List<KetQuaMB> lstGiai = new List<KetQuaMB>();
            KetQuaMB_Flat kq = new KetQuaMB_Flat();

            // tao link
            link = TaoLink(ngaylaykq);

            // lay ket qua
            var webGet = new HtmlWeb();

            HtmlAgilityPack.HtmlDocument html = webGet.Load(@link);

            //// HtmlDocument/ DocumentNode/ Descendents -> HtmlNode         
            var root = html.DocumentNode;


            foreach (var g in giai)
            {
                var ret = root.Descendants()
                    .Where(n => n.GetAttributeValue("class", "").Equals(g))
                    .FirstOrDefault()
                    ;

                if (ret != null && ret.Descendants("div") != null)
                {
                    foreach (var n in ret.Descendants("div"))
                    {
                        lstGiai.Add(new KetQuaMB() { Ngay_Quay = ngaylaykq, Ma_Giai = g, Ket_Qua = n.InnerText });
                    }
                }
            }
            

            // hien thi ket qua hoac save vao db            
            foreach (var d in lstGiai)
            {
                try 
                {
                    db.KetQuaMB.Add(d);              
                }
                catch (System.Data.Entity.ModelConfiguration.ModelValidationException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                  
            }

            // ket qua flat
            if (lstGiai.Count > 0)
            {
                kq = KetQua_MB_Flat(lstGiai, ngaylaykq);
                db.KetQuaMB_Flat.Add(kq);
            }
            

            db.SaveChanges();
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // so ngay lay ket qua
            //int day = dtpNgayKetThuc.Value.DayOfYear - dtpNgayBatDau.Value.DayOfYear;

            int day = (dtpNgayKetThuc.Value - dtpNgayBatDau.Value).Days;

            // ngay bat dau
            var startDate = dtpNgayBatDau.Value.Date;            

            // chay tu ngay bat dau -> ngay ket thuc
            for (var i = 0; i < day + 1; i++)
            {
                // lay ket qua
                LayKetQua(startDate);

                startDate = startDate.AddDays(1);

                backgroundWorker1.ReportProgress(
                                                    ((i==0?1:i) * 100) / (day==0?1:day));  // tinh % cua progress bar
            }
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Xong rồi!");
        }
    }
}
