using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations.Schema;

namespace WowRoads.Models
{
    public class Agent
    {
        public int AgentID { get; set; }
        public string AgentLastName { get; set; }
        public string AgentFirstName { get; set; }

        public int CustomerID {get; set;}

        public ICollection<Place>? Place { get; set; }
        public ICollection<Customer>? Customer { get; set; }
    }
}