using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFs.Models
{
    public class Admin
    {
        [Key]
        public string Id { get; set; }

        [Index(IsUnique = true)]
        [StringLength(200)]
        [Required(ErrorMessage ="Username is required.")]
        public string Username { get; set; }

        [Index(IsUnique = true)]
        [StringLength(320)]
        [Required(ErrorMessage ="Email is required.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Password is required.")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Type is required.")]
        public string Type { get; set; }
    }
}
