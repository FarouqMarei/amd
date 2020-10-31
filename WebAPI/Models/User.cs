using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebAPI.Models
{
    public class User : BaseModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int Type { get; set; }

        [ForeignKey("GroupId")]
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
