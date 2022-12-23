using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class RestaurantPaymentDTO : RestaurantDTO
    {
        public virtual List<PaymentDTO> Payments { get; set; }
        public RestaurantPaymentDTO()
        {
            Payments = new List<PaymentDTO>();
        }
    }
}
