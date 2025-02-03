using System;
using System.Collections.Generic;

namespace Models.Entities
{
	public class ChuNha
	{
		public string ChuNhaID { get; set; }
		public string TenChuNha { get; set; }
		public string Email { get; set; }
		public string SoDienThoai { get; set; }
		public List<HopDong> dsHopDong { get; set; } = new List<HopDong>();
		public List<TaiSan> dsTaiSan { get; set; } = new List<TaiSan>();
        public List<HoaDon> dsHoaDon { get; set; } = new List<HoaDon>();
    }
}