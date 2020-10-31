using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CreationUserId")]
        public int? CreationUserId { get; set; }
        public User CreationUser { get; set; }

        public DateTime? CreationDate { get; set; }

        [ForeignKey("ModificationUserId")]
        public int? ModificationUserId { get; set; }
        public User ModificationUser { get; set; }

        public DateTime? ModificationDate { get; set; }
    }
}
