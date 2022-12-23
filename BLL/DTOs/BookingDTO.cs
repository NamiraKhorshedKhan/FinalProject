using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class BookingDTO
    {
        public string Id { get; set; }
        public string CusId { get; set; }
        public string ResId { get; set; }
        public int Number { get; set; }
        public DateTime DateTime { get; set; }
        public string Status { get; set; }
    }
}
