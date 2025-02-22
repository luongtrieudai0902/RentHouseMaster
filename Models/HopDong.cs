using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public class HopDong
    {
        public string HopDongID { get; set; }
        public string KhachHangID { get; set; }
        public string TaisanID { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public double TienThue { get; set; }
        public double TienCoc { get; set; }
        public string DieuKhoan { get; set; }
        public bool AutoRenew { get; set; }
        public string StorageFilePath { get; set; }

        // Constructor không tham số (hỗ trợ khởi tạo bằng `{}`)
        public HopDong() { }

        // Constructor đầy đủ tham số
        public HopDong(string hopDongID, string khachHangID, string taiSanID,
                   DateTime ngayBatDau, DateTime ngayKetThuc, double tienThue,
                   double tienCoc, string dieuKhoan, string path, bool autoRenew)
        {
            this.HopDongID = hopDongID;
            this.KhachHangID = khachHangID;
            this.TaisanID = taiSanID;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.TienThue = tienThue;
            this.TienCoc = tienCoc;
            this.DieuKhoan = dieuKhoan;
            this.AutoRenew = autoRenew;
            this.StorageFilePath = path;
        }
    }
}
