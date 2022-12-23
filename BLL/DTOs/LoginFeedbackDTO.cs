using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class LoginFeedbackDTO : LoginDTO
    {
        public virtual List<FeedbackDTO> Feedbacks { get; set; }
        public LoginFeedbackDTO()
        {
            Feedbacks = new List<FeedbackDTO>();
        }
    }
}
