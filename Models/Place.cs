using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations.Schema;

namespace WowRoads.Models
{
    public class Place{
        public int PlaceID { get; set; }
        public string PlaceName { get; set; }

        
        public Vehicle Vehicle{ get; set; }
        public Agent Agent{ get; set; }
        public Guide Guide{ get; set; }
        public Hotel Hotel{ get; set; }
        
        
    }
}