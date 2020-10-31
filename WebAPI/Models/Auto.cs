using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public partial class Auto : BaseModel
    {
        [Required]
        public string Name { get; set; }

        [ForeignKey("BrandId")]
        public int BrandId { get; set; }
        public LookupValue Brand { get; set; }

        public string Description { get; set; }
        public string Model { get; set; }
        public string VinNo { get; set; }
        public int Type { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public string Lot { get; set; }

        public int? BuyingAccountId { get; set; }

        public decimal? RemainingPayment { get; set; }

        [ForeignKey("BuyerId")]
        public int? BuyerId { get; set; }
        public User Buyer { get; set; }

        [ForeignKey("LoadPortId")]
        public int LoadPortId { get; set; }
        public LookupValue LoadPort { get; set; }

        [ForeignKey("AuctionId")]
        public int AuctionId { get; set; }
        public LookupValue Auction { get; set; }

        [ForeignKey("CityId")]
        public int CityId { get; set; }
        public LookupValue City { get; set; }

        [ForeignKey("DestinationId")]
        public int DestinationId { get; set; }
        public LookupValue Destination { get; set; }

        [ForeignKey("ContainerId")]
        public int? ContainerId { get; set; }
        public Container Container { get; set; }

        public DateTime BuyDate { get; set; }
        public DateTime? ArrivalDate { get; set; }

        public int CarStatus { get; set; }
        public int? PaperStatus { get; set; }
        public int DisplayStatus { get; set; }
    }
}
