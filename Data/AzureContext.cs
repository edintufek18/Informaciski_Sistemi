using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WowRoads.Models;

namespace WowRoads.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<WowRoads.Models.Customer> Customer { get; set; }

        public DbSet<WowRoads.Models.Guide> Guide { get; set; }

        public DbSet<WowRoads.Models.Hotel> Hotel { get; set; }

        public DbSet<WowRoads.Models.Agent> Agent { get; set; }

        public DbSet<WowRoads.Models.Vehicle> Vehicle { get; set; }

        public DbSet<WowRoads.Models.Place> Place { get; set; }
    }
}
