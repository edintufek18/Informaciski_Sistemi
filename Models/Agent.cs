using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations.Schema;

namespace WowRoads.Models
{
    public class Agent
    {
        public int CustomerID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
     
        
        public ICollection<Place> Place { get; set; }
        public Customer Customer { get; set; }
    }
}