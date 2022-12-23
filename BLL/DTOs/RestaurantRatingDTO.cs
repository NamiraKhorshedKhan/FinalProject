using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class RestaurantRatingDTO : RestaurantDTO
    {
        public virtual List<RatingDTO> Ratings { get; set; }
        public RestaurantRatingDTO()
        {
            Ratings = new List<RatingDTO>();
        }
    }
}
