using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFs.Models
{
    public class Booking
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey("Customer")]
        public string CusId { get; set; }

        [ForeignKey("Restaurant")]
        public string ResId { get; set; }

        [Required(ErrorMessage ="Number of people is required.")]
        public int Number { get; set; }

        [Required(ErrorMessage ="Please select date and time.")]
        public DateTime DateTime { get; set; }

        [Required]
        public string Status { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual List<Payment> Payments { get; set; }
    }
}
