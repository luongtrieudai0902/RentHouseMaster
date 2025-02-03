using System;
using System.Collections.Generic;
using System.Linq;

namespace Models.Entities
{
	public class NhanVien
	{
		public string NhanVienID { get; set; }
		public string TenNhanVien { get; set; }
		public string Email { get; set; }
		public string SoDienThoai { get; set; }
		public List<HoaDon> dsHoaDon { get; set; } = new List<HoaDon>();
		public List<Dien> DSChiSoDien { get; set; } = new List<Dien>();
		public List<Nuoc> DSChiSoNuoc { get; set; } = new List<Nuoc>();
	}
}