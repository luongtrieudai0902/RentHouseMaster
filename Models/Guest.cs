using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentHouseMaster.Models
{
    public class Guest
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string IdType { get; set; } // Loại giấy tờ
        public string IdNumber { get; set; } // Số giấy tờ
        public string Nationality { get; set; } // Quốc tịch
        public string Province { get; set; } // Tỉnh/TP
        public string District { get; set; } // Quận/Huyện
        public string Ward { get; set; } // Xã/Phường/Thị trấn
        public string Address { get; set; } // Địa chỉ chi tiết
    }
}
