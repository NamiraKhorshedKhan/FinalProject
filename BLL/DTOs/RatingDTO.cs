using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class RatingDTO
    {
        public string Id { get; set; }
        public string CusId { get; set; }
        public string ResId { get; set; }
        public int Rate { get; set; }
    }
}
