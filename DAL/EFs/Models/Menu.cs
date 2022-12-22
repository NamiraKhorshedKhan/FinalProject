using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFs.Models
{
    public class Menu
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey("Restaurant")]
        public string ResId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Type is required.")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        public float Price { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
