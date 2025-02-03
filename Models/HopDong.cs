using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public class HopDong
    {
        public string HopDongID { get; set; }
        public string KhachHangID { get; set; }
        public string TaisanID { get; set; }
        public string NgayBatDau { get; set; }
        public string NgayKetThuc { get; set; }
        public double TienThue { get; set; }
        public double TienCoc { get; set; }
        public string DieuKhoan { get; set; }
    }
}
