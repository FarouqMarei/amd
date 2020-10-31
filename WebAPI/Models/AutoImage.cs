using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class AutoImage : BaseModel
    {
        [Required]
        public byte[] Image { get; set; }

        [ForeignKey("ContainerId")]
        public int ContainerId { get; set; }
        public Container Container { get; set; }
    }
}
