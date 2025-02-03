using System;
using System.Collections.Generic;
using System.Linq;

namespace Models.Entities
{
    public class Nuoc
    {
        public string NuocID { get; set; }
        public string TaiSanID { get; set; }
        public string NhanVienID { get; set; }
        public int ThangGhi { get; set; }
        public int SoGhi { get; set; }
    }
}