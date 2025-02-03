using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public class Dien
    {
        public string DienID { get; set; }
        public string TaiSanID { get; set; }
        public string NhanVienID { get; set; }
        public int ThangGhi { get; set; }
        public int SoGhi { get; set; }
    }
}