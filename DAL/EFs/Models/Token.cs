using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFs.Models
{
    public class Token
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Tkey { get; set; }

        [Required]
        public DateTime Creation { get; set; }

        [Required]
        public DateTime Expiration { get; set; }

        [ForeignKey("Login")]
        public string LoginId { get; set; }

        public virtual Login Login { get; set; }
    }
}
