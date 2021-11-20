using WowRoads.Data;
using WowRoads.Models;
using System;
using System.Linq;

namespace WowRoads.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Customer.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {

                new Customer{FirstMidName="A",LastName="E"},
                new Customer{FirstMidName="B",LastName="F"},
                new Customer{FirstMidName="C",LastName="G"},
                new Customer{FirstMidName="D",LastName="H"},
                new Customer{FirstMidName="I",LastName="J"},

            };


            context.Customer.AddRange(customers);
            context.SaveChanges();

            var agent = new Agent[]
            {
                new Agent{AgentFirstName="AA",AgentLastName="BB"},
                new Agent{AgentFirstName="CC",AgentLastName="DD"},
                new Agent{AgentFirstName="EE",AgentLastName="FF"},
                new Agent{AgentFirstName="GG",AgentLastName="HH"},




            };

            context.Agent.AddRange(agent);
            context.SaveChanges();

            var vehicle = new Vehicle[]
            {
                new Vehicle{VehicleType="AAA",VehicleBrand="BBB",VehicleYear=2020},
                new Vehicle{VehicleType="BBB",VehicleBrand="CCC",VehicleYear=2021},
                new Vehicle{VehicleType="DDD",VehicleBrand="EEE",VehicleYear=2022},
                new Vehicle{VehicleType="FFF",VehicleBrand="HHH",VehicleYear=2019},


            };

            context.Vehicle.AddRange(vehicle);
            context.SaveChanges();

            var hotel = new Hotel[]
            {
                new Hotel{Name="AAAA",Stars=Stars.One},
                new Hotel{Name="BBBB",Stars=Stars.Two},
                new Hotel{Name="CCCC",Stars=Stars.Three},
                new Hotel{Name="DDDD",Stars=Stars.Four},
                new Hotel{Name="EEEE",Stars=Stars.Five},


            };
            context.Hotel.AddRange(hotel);
            context.SaveChanges();


            var place = new Place[]
            {
                new Place{PlaceName="AAAAA"},
                new Place{PlaceName="BBBBB"},
                new Place{PlaceName="CCCCC"},
                new Place{PlaceName="DDDDD"},
                new Place{PlaceName="EEEEE"},


            };
            context.Place.AddRange(place);
            context.SaveChanges();


            var guide = new Guide[]
            {
                new Guide{FirstNameGuide="AAAAAA"},
                new Guide{FirstNameGuide="BBBBBB"},
                new Guide{FirstNameGuide="CCCCCC"},
                new Guide{FirstNameGuide="DDDDDD"},
                new Guide{FirstNameGuide="EEEEEE"},



            };
            context.Guide.AddRange(guide);
            context.SaveChanges();

            Console.WriteLine(agent.Length);














        }
    }
}