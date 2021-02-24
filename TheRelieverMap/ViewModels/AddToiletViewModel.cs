using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TheRelieverMap.Models;

namespace TheRelieverMap.ViewModels
{
    public class AddToiletViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public int Type { get; set; }

        public IEnumerable<ToiletType> Types { get; set; }

        [Required]
        public int State { get; set; }

        public IEnumerable<State> States { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int Compatibility { get; set; }

        public IEnumerable<Compatible> Compatible { get; set; }

        public string Heading { get; set; }

        public string Action
        {
            get
            {
                return (Id != 0) ? "Update" : "Add";
            }
        }

    }
}