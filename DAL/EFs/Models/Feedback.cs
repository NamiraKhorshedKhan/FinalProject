using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFs.Models
{
    public class Feedback
    {
        [Key]
        public string Id { get; set; }
        
        [ForeignKey("Login")]
        public string UserId { get; set; }

        [Required(ErrorMessage ="Please specify your complaint.")]
        public string Comment { get; set; }

        [Required]
        public string Status { get; set; }

        public virtual Login Login { get; set; }
    }
}
