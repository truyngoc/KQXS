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
    public partial class frmDacBiet : Form
    {
        XSMBContext db = new XSMBContext();

        public frmDacBiet()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            var lst_ID = db.KetQuaMB_Flat.Where(o => o.Ngay_Quay >= dtpNgayBatDau.Value.Date
                                                                && o.Ngay_Quay <= DateTime.Today
                                                                && o.Giai_DB.EndsWith(txtSoDB.Text.Substring(3, 2)));

            var _lst_ID_Before = lst_ID.Select(s => s.ID - 1).ToList();
            var _lst_ID_Current = lst_ID.Select(s => s.ID).ToList();
            var _lst_ID_After = lst_ID.Select(s => s.ID + 1).ToList();

            var lstBefore = db.KetQuaMB_Flat.Where(o => _lst_ID_Before.Contains(o.ID)).Select(s => new { s.Ngay_Quay, s.Giai_DB }).ToList();
            var lstCurrent = db.KetQuaMB_Flat.Where(o => _lst_ID_Current.Contains(o.ID)).Select(s => new { s.Ngay_Quay, s.Giai_DB }).ToList();
            var lstAfter = db.KetQuaMB_Flat.Where(o => _lst_ID_After.Contains(o.ID)).Select(s => new { s.Ngay_Quay, s.Giai_DB }).ToList();


            dgvKetQuaBefore.DataSource = lstBefore;
            dataGridView1.DataSource = lstCurrent;
            dgvKetQuaAfter.DataSource = lstAfter;
        }

        private void frmDacBiet_Load(object sender, EventArgs e)
        {
            var current_DacBiet = db.KetQuaMB_Flat.OrderByDescending(o => o.Ngay_Quay).First().Giai_DB;

            txtSoDB.Text = current_DacBiet;
        }

        private Dictionary<int, string> Position_And_Number(string ketqua)
        {
            Dictionary<int, string> dictPosNum = new Dictionary<int, string>();

            char[] arrKetqua = ketqua.ToArray();

            for (var i = 0; i < arrKetqua.Length; i++)
            {
                dictPosNum.Add(i, arrKetqua[i].ToString());
            }
                
            return dictPosNum;
        }

        private void btnCauDe_Click(object sender, EventArgs e)
        {

            var dateSoi = DateTime.Today.Date;

            var lst_DB = db.KetQuaMB_Flat.OrderByDescending(d => d.Ngay_Quay).Where(o => o.Ngay_Quay < dateSoi).Select(s => new KetQuaMB_Serialize()
            {
                Ngay_Quay = s.Ngay_Quay,
                Chuoi_Serialize = s.Giai_DB
                                +s.Giai_1
                                +s.Giai_21
                                +s.Giai_22
                                +s.Giai_31
                                +s.Giai_32
                                +s.Giai_33
                                +s.Giai_34
                                +s.Giai_35
                                +s.Giai_36
                                +s.Giai_41
                                +s.Giai_42
                                +s.Giai_43
                                +s.Giai_44
                                +s.Giai_51
                                +s.Giai_52
                                +s.Giai_53
                                +s.Giai_54
                                +s.Giai_55
                                +s.Giai_56
                                +s.Giai_61
                                +s.Giai_62
                                +s.Giai_63
                                +s.Giai_71
                                +s.Giai_72
                                +s.Giai_73
                                +s.Giai_74 
            }).Take(5).ToList();

            // duyet tung ngay
            // lay cac pos cua so tuong ung voi dau giai db
            // loc pos do o ngay tiep theo
            // dung lai neu ko con tim thay so theo pos
          
            List<Dictionary<int, string>> lst_Dau = new List<Dictionary<int, string>>();
            List<Dictionary<int, string>> lst_Duoi = new List<Dictionary<int, string>>();
            for (var i = 0; i < lst_DB.Count -1 ; i++)
            {
                var dau = lst_DB[i].Chuoi_Serialize.Substring(3, 1);
                var duoi = lst_DB[i].Chuoi_Serialize.Substring(4, 1);

                var onNext = Loc_Chuoi(Position_And_Number(lst_DB[i + 1].Chuoi_Serialize), dau);
                var onPrev = Loc_Chuoi(Position_And_Number(lst_DB[i + 1].Chuoi_Serialize), duoi);

                lst_Dau.Add(onNext);
                lst_Duoi.Add(onPrev);        
            }

            int iDau = 0;
            foreach (var s in lst_Dau)
            {
                string s1 = "";
                foreach (var d in s.Keys)
                {
                    if (iDau == 0)
                    {
                        s1 = s1 + d.ToString() + "[" + lst_DB[0].Chuoi_Serialize[d] + "]" + " ; ";
                    }
                    else
                    {
                        s1 = s1 + d.ToString() + " ; ";
                    }
                    
                }

                txtDau.AppendText(s1 + "\n");

                iDau++;
            }

            int iDuoi = 0;
            foreach (var s in lst_Duoi)
            {
                string s1 = "";
                foreach (var d in s.Keys)
                {
                    if (iDuoi == 0)
                    {
                        s1 = s1 + d.ToString() + "[" + lst_DB[0].Chuoi_Serialize[d] + "]" + " ; ";
                    }
                    else
                    {
                        s1 = s1 + d.ToString() + " ; ";
                    }
                }

                txtDuoi.AppendText(s1 + "\n");

                iDuoi++;
            }
        }

     
        Dictionary<int, string> Loc_Chuoi(Dictionary<int, string> dict, string chuoi_loc)
        {
            Dictionary<int, string> dict_Dau = new Dictionary<int, string>();

            
            foreach (var num in dict)
            {
                if (num.Value == chuoi_loc)
                {
                    dict_Dau.Add(num.Key, num.Value);
                }
            }

            return dict_Dau;
        }

    }
}
