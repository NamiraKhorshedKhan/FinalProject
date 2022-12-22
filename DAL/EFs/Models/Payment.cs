using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFs.Models
{
    public class Payment
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey("Booking")]
        public string BookingId { get; set; }

        [Required(ErrorMessage = "Amount is required.")]
        public float Amount { get; set; }

        [Required(ErrorMessage = "Date & time is required.")]
        public DateTime DateTime { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        public string Status { get; set; }

        [ForeignKey("Customer")]
        public string CusId { get; set; }

        [ForeignKey("Restaurant")]
        public string ResId { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
