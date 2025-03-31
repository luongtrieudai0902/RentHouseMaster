using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentHouseMaster.Models
{
    public class Accommodation
    {
        public int Id { get; set; }
        public int GuestId { get; set; }
        public string AccommodationPlace { get; set; } // Cơ sở lưu trú
        public string Room { get; set; } // Phòng
        public DateTime CheckInDate { get; set; } // Thời gian lưu trú
    }
}
