using System;
using System.Collections.Generic;
using Models.Entities;

namespace Models.Services
{
    public class ChuNhaServices
    {
        public void TaoHopDong(ChuNha chuNha, HopDong hopDong)
        {
            chuNha.dsHopDong.Add(hopDong);
        }

        public void XoaHopDong(ChuNha chuNha, HopDong hopDong)
        {
            if (chuNha.dsHopDong == null || chuNha.dsHopDong.Count == 0)
            {
                Console.WriteLine("Không có hợp đồng nào để xóa.");
            }

            for (int i = chuNha.dsHopDong.Count - 1; i >= 0; i--)
            {
                if (chuNha.dsHopDong[i].HopDongID == hopDong.HopDongID)
                {
                    chuNha.dsHopDong.RemoveAt(i);
                    Console.WriteLine("Đã xóa");
                }
            }
        }


        public void LuuTruHopDong(ChuNha chuNha, HopDong hopDong)
        {
            bool isExist = false;
            for (int i = 0; i < chuNha.dsHopDong.Count; i++)
            {
                if (chuNha.dsHopDong[i].HopDongID == hopDong.HopDongID)
                {
                    chuNha.dsHopDong[i] = hopDong;
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                chuNha.dsHopDong.Add(hopDong);
            }
        }

        public void GiaHanHopDong(ChuNha chuNha, HopDong hopDong, string ngayGiaHan)
        {
            if (chuNha.dsHopDong == null || chuNha.dsHopDong.Count == 0)
            {
                Console.WriteLine("Không có hợp đồng nào để gia hạn.");
            }

            for (int i = 0; i < chuNha.dsHopDong.Count; i++)
            {
                if (chuNha.dsHopDong[i].HopDongID == hopDong.HopDongID)
                {
                    chuNha.dsHopDong[i].NgayKetThuc = ngayGiaHan;
                    return;
                }
            }
        }

        public void CapNhatHopDong(HopDong hopDong, string ngayKT, double tienThue, string DieuKhoan)
        {
            hopDong.NgayKetThuc = ngayKT;
            hopDong.TienThue = tienThue;
            if (!string.IsNullOrEmpty(DieuKhoan))
            {
                hopDong.DieuKhoan = DieuKhoan;
            }
        }

        public void QuanLyTaiSan(ChuNha chuNha, TaiSan taiSan)
        {
            chuNha.dsTaiSan.Add(taiSan);
        }

        public double ThongKeDoanhThu(ChuNha chuNha, TaiSan taiSan)
        {
            double doanhThu = 0;
            double tienThue = 0;
            double tienHoaDon = 0;

            for (int i = 0; i < chuNha.dsHopDong.Count; i++)
            {
                if (chuNha.dsHopDong[i].TaisanID == taiSan.TaiSanID)
                {
                    tienThue += chuNha.dsHopDong[i].TienThue;
                }
            }

            for (int i = 0; i < chuNha.dsHoaDon.Count; i++)
            {
                if (chuNha.dsHoaDon[i].TaiSanID == taiSan.TaiSanID)
                {
                    tienHoaDon += chuNha.dsHoaDon[i].TongTien();
                }
            }

            doanhThu = tienThue + tienHoaDon;
            return doanhThu;
        }

    }
}
