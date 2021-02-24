﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheRelieverMap.Models
{
    public class State
    {
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }

    }
}