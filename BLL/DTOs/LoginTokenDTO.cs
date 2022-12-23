using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class LoginTokenDTO : LoginDTO
    {
        public virtual List<TokenDTO> Tokens { get; set; }
        public LoginTokenDTO()
        {
            Tokens = new List<TokenDTO>();
        }
    }
}
