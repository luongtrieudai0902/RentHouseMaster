using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public class HoaDon
    {
        public string HoaDonID { get; set; }
        public string KhachHangID { get; set; }
        public string TaiSanID { get; set; }
        public int Thang { get; set; }
        public double TienThue { get; set; }
        public double TienDien { get; set; }
        public double TienNuoc { get; set; }
        public double TienDichVu { get; set; }
        public bool DaThanhToan { get; set; } = false;

        public double TongTien()
        {
            return TienThue + TienDien + TienNuoc + TienDichVu;
        }

        public void ThanhToan()
        {
            DaThanhToan = true;
        }
    }
}