using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CustomerReviewDTO : CustomerDTO
    {
        public virtual List<ReviewDTO> Reviews { get; set; }

        public CustomerReviewDTO()
        {
            Reviews = new List<ReviewDTO>();
        }
    }
}
