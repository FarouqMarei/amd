using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public partial class Auto
    {
        [NotMapped]
        public string BrandName { get; set; }
        [NotMapped]
        public string BuyerName { get; set; }
        [NotMapped]
        public string LoadPortName { get; set; }
        [NotMapped]
        public string AuctionName { get; set; }
        [NotMapped]
        public string CityName { get; set; }
        [NotMapped]
        public string DestinationName { get; set; }
        [NotMapped]
        public string ContainerSerial { get; set; }
        [NotMapped]
        public string DisplayStatusStr { get; set; }
        [NotMapped]
        public string CarStatusStr { get; set; }
        [NotMapped]
        public string PaperStatusStr { get; set; }
    }
}
