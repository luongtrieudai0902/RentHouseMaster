using System;
using System.Collections.Generic;
using Models.Entities;

namespace Models.Services
{
    public class NhanVienServices
    {
        public void GhiNhanSoDien(string dienID, string taiSanID, NhanVien nhanVien, int thang, int soDien)
        { 
            if (nhanVien.DSChiSoDien == null)
            {
                nhanVien.DSChiSoDien = new List<Dien>();
            }

            nhanVien.DSChiSoDien.Add(new Dien
            {
                DienID = dienID,
                TaiSanID = taiSanID,
                NhanVienID = nhanVien.NhanVienID,
                ThangGhi = thang,
                SoGhi = soDien
            });
        }

        public void GhiNhanSoNuoc(string nuocID, string taiSanID, NhanVien nhanVien, int thang, int soNuoc)
        {
            if (nhanVien.DSChiSoNuoc == null)
            {
                nhanVien.DSChiSoNuoc = new List<Nuoc>();
            }
            nhanVien.DSChiSoNuoc.Add(new Nuoc
            {
                NuocID = nuocID,
                TaiSanID = taiSanID,
                NhanVienID = nhanVien.NhanVienID,
                ThangGhi = thang,
                SoGhi = soNuoc
            });
        }

        public double TienDien(NhanVien nhanVien, int thang, double giaDien)
        {
            if (nhanVien.DSChiSoDien == null || nhanVien.DSChiSoDien.Count == 0)
            {
                return 0;
            }

            double tongTienDien = 0;
            for (int i = 0; i < nhanVien.DSChiSoDien.Count; i++)
            {
                if (nhanVien.DSChiSoDien[i].ThangGhi == thang)
                {
                    tongTienDien += nhanVien.DSChiSoDien[i].SoGhi * giaDien;
                }
            }
            return tongTienDien;
        }

        public double TienNuoc(NhanVien nhanVien, int thang, double giaNuoc)
        {
            if (nhanVien.DSChiSoNuoc == null || nhanVien.DSChiSoNuoc.Count == 0)
            {
                return 0;
            }

            double tongTienNuoc = 0;
            for (int i = 0; i < nhanVien.DSChiSoNuoc.Count; i++)
            {
                if (nhanVien.DSChiSoNuoc[i].ThangGhi == thang)
                {
                    tongTienNuoc += nhanVien.DSChiSoNuoc[i].SoGhi * giaNuoc;
                }
            }
            return tongTienNuoc;
        }

        public double TienDichVu(NhanVien nhanVien, int thang, int SLDichVu, double giaDichVu)
        {
            return SLDichVu * giaDichVu;
        }

        public void TaoHoaDon(NhanVien nhanVien, KhachThue khachThue, HoaDon hoaDon)
        {
            if (hoaDon == null)
            {
                Console.WriteLine("Không thể tạo hóa đơn vì dữ liệu không hợp lệ.");
                return;
            }

            if (nhanVien.dsHoaDon == null)
            {
                nhanVien.dsHoaDon = new List<HoaDon>();
            }

            if (khachThue.dsHoaDon == null)
            {
                khachThue.dsHoaDon = new List<HoaDon>();
            }

            nhanVien.dsHoaDon.Add(hoaDon);
            khachThue.dsHoaDon.Add(hoaDon);
        }

        public void CapNhatGiaDichVu(HoaDon hoaDon, double tienDichVu)
        {
            hoaDon.TienDichVu = tienDichVu;
        }
    }

            