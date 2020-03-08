using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MpgMvc.Models
{
    public class Mileage
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public decimal Miles { get; set; }
        public decimal Gallons { get; set; }
        public decimal MPG { get { return Miles / Gallons; } }
        [DisplayFormat(DataFormatString = "{0:C}")]
        [DisplayName("$/Gal.")]
        public decimal PriceGallon { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        [DisplayName("Total")]
        public decimal TotalCost { get { return Gallons * PriceGallon; } }
        public int? VehicleID { get; set; }
        public int? UserID { get; set; }
        public string Comment { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        [DisplayName("Created")]
        public DateTime CreateDt { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        [DisplayName("Updated")]
        public DateTime? LastUpdateDt { get; set; }
        public Vehicle Vehicle { get; set; }
        public User User { get; set; }
    }
}