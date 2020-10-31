using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class LookupValue
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Code { get; set; }

        [ForeignKey("LookupId")]
        public int LookupId { get; set; }
        public Lookup Lookup { get; set; }
    }
}
