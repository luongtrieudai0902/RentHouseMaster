using System;
using System.Collections.Generic;
using System.Linq;

namespace Models.Entities
{
    public class KhachThue
    {
        public string KhachThueID { get; set; }
        public string TenKhachThue { get; set; }
        public string CCCD { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public List<HopDong> dsHopDong { get; set; } = new List<HopDong>();
        public List<HoaDon> dsHoaDon { get; set; } = new List<HoaDon>();
    }
}