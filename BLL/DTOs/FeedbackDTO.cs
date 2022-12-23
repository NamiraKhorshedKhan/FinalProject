using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class FeedbackDTO
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }
    }
}
