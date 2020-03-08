using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MpgMvc.Models
{
    public class Vehicle
    {
        public int ID { get; set; }
        public int? UserID { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Trim { get; set; }
        public string Color { get; set; }
        [DisplayName("VIN")]
        public string Vin { get; set; }
        [DisplayName("Purchase Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DatePurchased { get; set; }
        [DisplayName("Sell Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateSold { get; set; }
        [DisplayName("Original Miles")]
        public int MileagePurchased { get; set; }
        [DisplayName("Current Miles")]
        public int MileageCurrent { get; set; }
        [DisplayName("Sold Miles")]
        public int? MileageSold { get; set; }
        [DisplayName("Purchase Price")]
        public decimal PricePurchased { get; set; }
        [DisplayName("Sell Price")]
        public decimal? PriceSold { get; set; }
        [DisplayName("Created")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        public DateTime CreateDt { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        [DisplayName("Last Updated")]
        public DateTime LastUpdateDt { get; set; }
        [DisplayName("Default")]
        public bool DefaultVehicle { get; set; }

        public virtual User User { get; set; }
    }
}