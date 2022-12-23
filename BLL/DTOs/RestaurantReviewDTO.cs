using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class RestaurantReviewDTO : RestaurantDTO
    {
        public virtual List<ReviewDTO> Reviews { get; set; }
        public RestaurantReviewDTO()
        {
            Reviews = new List<ReviewDTO>();
        }
    }
}
