using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFs.Models
{
    public class Review
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey("Customer")]
        public string CusId { get; set; }

        [ForeignKey("Restaurant")]
        public string ResId { get; set; }

        [Required(ErrorMessage = "Please provide your review.")]
        public string Comment { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
