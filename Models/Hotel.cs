using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace WowRoads.Models
{
    public enum Stars
    {
        One, Two, Three, Four, Five
    }
    public class Hotel
    {
        
        public int HotelID { get; set; }
        public string Name { get; set; }
        public Stars? Stars { get; set; }

        public ICollection<Place>? Place { get; set; }
    }
}