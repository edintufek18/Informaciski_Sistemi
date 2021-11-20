using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations.Schema;

namespace WowRoads.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }


        public ICollection<Vehicle>? Vehicle { get; set; }
        public ICollection<Agent>? Agent { get; set; }
    }
}