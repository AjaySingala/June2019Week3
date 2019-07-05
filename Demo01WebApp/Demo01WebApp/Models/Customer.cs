using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01WebApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Firstname { get; set; }

        [StringLength(5)]
        [Required]
        [Display(Name ="Last name")]
        public string Lastname { get; set; }

        public virtual IList<Order> Orders { get; set; }
    }
}
