using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CustomerBookingDTO : CustomerDTO
    {
        public virtual List<BookingDTO> Bookings { get; set; }
      
        public CustomerBookingDTO()
        {
            Bookings = new List<BookingDTO>();
        }
    }
}
