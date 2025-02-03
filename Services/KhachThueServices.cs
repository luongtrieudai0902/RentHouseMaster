using System;
using System.Collections.Generic;
using Models.Entities;

namespace Models.Services
{
    public class KhachThueServices 
    {
        public void DangKyThongTin(KhachThue khachThue, string tenKhachHang, int CCCD, string email, string soDienThoai)
		{
			khachThue.TenKhachThue = tenKhachHang;
			khachThue.CCCD = CCCD;
			khachThue.Email = email;
			khachThue.SoDienThoai = soDienThoai;
		}

		public List<HopDong> XemThongTinHopDong(KhachThue khachThue)
		{
			return new List<HopDong>(khachThue.dsHopDong);
		}

		public List<HoaDon> XemThongTinHoaDon(KhachThue khachThue)
		{
			return new List<HoaDon>(khachThue.dsHoaDon);
		}

		public void ThanhToanHoaDon(KhachThue khachThue, string HoaDonID)
		{
			if (khachThue.dsHoaDon == null || khachThue.dsHoaDon.Count == 0)
			{
				Console.WriteLine("Không có hóa đơn nào để thanh toán");
			}

			for (int i = 0; i < khachThue.dsHoaDon.Count; i++)
			{
				if (khachThue.dsHoaDon[i].HoaDonID == HoaDonID)
				{
					khachThue.dsHoaDon[i].ThanhToan();
					break;
				}
			}
		}

		public List<HoaDon> XemLichSuThanhToan(KhachThue khachThue)
		{
			List<HoaDon> dsHoaDonDaThanhToan = new List<HoaDon>();


			if (khachThue.dsHoaDon.Count == 0)
			{
				Console.WriteLine("Không có hóa đơn nào để thanh toán");
			}

			for (int i = 0; i < khachThue.dsHoaDon.Count; i++)
			{
				if (khachThue.dsHoaDon[i].DaThanhToan)
				{
					dsHoaDonDaThanhToan.Add(khachThue.dsHoaDon[i]);
				}
			}

			if (dsHoaDonDaThanhToan.Count == 0)
			{
				Console.WriteLine("Không có hóa đơn nào đã thanh toán");
			}

			return dsHoaDonDaThanhToan;
		}
	}
}