using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheRelieverMap.Models
{
    public class AddToilet
    {
        public bool IsCancelled { get; set; }

        public int Id { get; set; }
        [Required]
        public ApplicationUser Provider { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public ToiletType Type { get; set; }

        [Required]
        public State State { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [StringLength(150)]
        public string Address { get; set; }

        [Required]
        public Compatible Compatibility { get; set; }
    }
}