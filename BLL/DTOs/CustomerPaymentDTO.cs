using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CustomerPaymentDTO : CustomerDTO
    {
        public virtual List<PaymentDTO> Payments { get; set; }
        public CustomerPaymentDTO()
        {
            Payments = new List<PaymentDTO>();
        }
    }
}
