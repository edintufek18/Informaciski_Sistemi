using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations.Schema;

namespace WowRoads.Models
{
    

    public class Vehicle
    {
        public int VehicleID { get; set; }
        public String VehicleBrand { get; set; }
        public int VehicleYear { get; set; }
        public String VehicleType { get; set; }

       
        public Customer Customer { get; set; }
         public ICollection<Place> Place { get; set; }
    }
}