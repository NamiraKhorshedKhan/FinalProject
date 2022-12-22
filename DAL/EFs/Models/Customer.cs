using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFs.Models
{
    public class Customer
    {
        [Key]
        public string Id { get; set; }

        [Index(IsUnique = true)]
        [StringLength(200)]
        [Required(ErrorMessage="Username is required.")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Your name is required.")]
        public string Name { get; set; }

        [Index(IsUnique = true)]
        [StringLength(320)]
        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Password is required.")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Contact number is required.")]
        [RegularExpression(@"^([0-9]{11})$", ErrorMessage = "Invalid mobile number.")]
        public int Contact { get; set; }

        [Required(ErrorMessage ="Type is required.")]
        public string Type { get; set; }

        public virtual List<Booking> Bookings { get; set; }
        public virtual List<Payment> Payments { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public virtual List<Rating> Ratings { get; set; }

        public Customer()
        {
            Bookings = new List<Booking>();
            Payments = new List<Payment>();
            Reviews = new List<Review>();
            Ratings = new List<Rating>();
        }

    }
}
