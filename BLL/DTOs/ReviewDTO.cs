using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ReviewDTO
    {
        public string Id { get; set; }
        public string CusId { get; set; }
        public string ResId { get; set; }
        public string Comment { get; set; }
    }
}
