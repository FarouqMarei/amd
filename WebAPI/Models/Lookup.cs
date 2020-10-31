using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Lookup
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
