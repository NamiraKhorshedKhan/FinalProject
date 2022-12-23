using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class RestaurantBookingDTO : RestaurantDTO
    {
        public virtual List<BookingDTO> Bookings { get; set; }
        public RestaurantBookingDTO()
        {
            Bookings = new List<BookingDTO>();
        }
    }
}
