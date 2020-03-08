using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MpgMvc.Models
{
    public class User
    {
        public int ID { get; set; }
        [DisplayName("User")]
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime LastLoginDt { get; set; }
        public DateTime CreatedDt { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public virtual ICollection<Mileage> Mileages { get; set; }
    }
}