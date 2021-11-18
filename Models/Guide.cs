using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations.Schema;

namespace WowRoads.Models
{
    public class Guide
    {
        public int GuideID { get; set; }
        public string LastNameGuide { get; set; }
        public string FirstNameGuide { get; set; }
     
        
        public ICollection<Place> Place { get; set; }
    }
}