using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TestString
{
    public class KetQuaMB
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Ngay_Quay { get; set; }
        public string Ma_Giai { get; set; }
        public string Ket_Qua { get; set; }
    }

    public class KetQuaMB_Flat
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Ngay_Quay { get; set; }

        public string Giai_DB { get; set; }
        public string Giai_1 { get; set; }
        public string Giai_21 { get; set; }
        public string Giai_22 { get; set; }
        public string Giai_31 { get; set; }
        public string Giai_32 { get; set; }
        public string Giai_33 { get; set; }
        public string Giai_34 { get; set; }
        public string Giai_35 { get; set; }
        public string Giai_36 { get; set; }
        public string Giai_41 { get; set; }
        public string Giai_42 { get; set; }
        public string Giai_43 { get; set; }
        public string Giai_44 { get; set; }
        public string Giai_51 { get; set; }
        public string Giai_52 { get; set; }
        public string Giai_53 { get; set; }
        public string Giai_54 { get; set; }
        public string Giai_55 { get; set; }
        public string Giai_56 { get; set; }
        public string Giai_61 { get; set; }
        public string Giai_62 { get; set; }
        public string Giai_63 { get; set; }
        public string Giai_71 { get; set; }
        public string Giai_72 { get; set; }
        public string Giai_73 { get; set; }
        public string Giai_74 { get; set; }
    }
}
