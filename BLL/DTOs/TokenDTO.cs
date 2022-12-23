using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TokenDTO
    {
        public string Id { get; set; }
        public string Tkey { get; set; }
        public DateTime Creation { get; set; }
        public DateTime Expiration { get; set; }
        public string LoginId { get; set; }
    }
}
