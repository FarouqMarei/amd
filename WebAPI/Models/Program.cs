﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Program : BaseModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Type { get; set; }
    }
}
