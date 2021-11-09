using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations.Schema;

namespace WowRoads.Models
{
    public class Guide
    {
        public int GuideID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
     
        
        public ICollection<Place> Place { get; set; }
    }
}