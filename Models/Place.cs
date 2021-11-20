using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations.Schema;

namespace WowRoads.Models
{
    public class Place
    {
        public int PlaceID { get; set; }
        public string PlaceName { get; set; }


        public ICollection<Vehicle>? Vehicle { get; set; }
        public ICollection<Agent>? Agent { get; set; }
        public ICollection<Guide>? Guide { get; set; }
        public ICollection<Hotel>? Hotel { get; set; }



    }
}