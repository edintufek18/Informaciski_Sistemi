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
                
                new Customer{FirstMidName="A",LastName="E",CustomerID=1},
                new Customer{FirstMidName="B",LastName="F",CustomerID=2},
                new Customer{FirstMidName="C",LastName="G",CustomerID=3},
                new Customer{FirstMidName="D",LastName="H",CustomerID=4},
                new Customer{FirstMidName="I",LastName="J",CustomerID=5},
               
            };

            context.Customer.AddRange(customers);
            context.SaveChanges();

            var agent = new Agent[]
            {
                new Agent{AgentFirstName="AA",AgentLastName="BB",AgentID=11},
                new Agent{AgentFirstName="CC",AgentLastName="DD",AgentID=22},
                new Agent{AgentFirstName="EE",AgentLastName="FF",AgentID=33},
                new Agent{AgentFirstName="GG",AgentLastName="HH",AgentID=44},



                
            };

            context.Agent.AddRange(agent);
            context.SaveChanges();

            var vehicle = new Vehicle[]
            {
                new Vehicle{VehicleID=111,VehicleType="AAA",VehicleBrand="BBB",VehicleYear=2020},
                new Vehicle{VehicleID=222,VehicleType="BBB",VehicleBrand="CCC",VehicleYear=2021},
                new Vehicle{VehicleID=333,VehicleType="DDD",VehicleBrand="EEE",VehicleYear=2022},
                new Vehicle{VehicleID=111,VehicleType="FFF",VehicleBrand="HHH",VehicleYear=2019},

                
            };

            context.Vehicle.AddRange(vehicle);
            context.SaveChanges();

            var hotel = new Hotel[]
            {
                new Hotel{HotelID=1111,Name="AAAA",Stars=Stars.One},
                new Hotel{HotelID=2222,Name="BBBB",Stars=Stars.Two},
                new Hotel{HotelID=3333,Name="CCCC",Stars=Stars.Three},
                new Hotel{HotelID=4444,Name="DDDD",Stars=Stars.Four},
                new Hotel{HotelID=5555,Name="EEEE",Stars=Stars.Five},
                
                
            };
            context.Hotel.AddRange(hotel);
            context.SaveChanges();


            var place = new Place[]
            {
                new Place{PlaceID=11111,PlaceName="AAAAA"},
                new Place{PlaceID=22222,PlaceName="BBBBB"},
                new Place{PlaceID=33333,PlaceName="CCCCC"},
                new Place{PlaceID=44444,PlaceName="DDDDD"},
                new Place{PlaceID=55555,PlaceName="EEEEE"},
                
                
            };
            context.Place.AddRange(place);
            context.SaveChanges();


            var guide = new Guide[]
            {
                new Guide{GuideID=111111,FirstNameGuide="AAAAAA"},
                new Guide{GuideID=222222,FirstNameGuide="BBBBBB"},
                new Guide{GuideID=333333,FirstNameGuide="CCCCCC"},
                new Guide{GuideID=444444,FirstNameGuide="DDDDDD"},
                new Guide{GuideID=555555,FirstNameGuide="EEEEEE"},
                
                
                
            };
            context.Guide.AddRange(guide);
            context.SaveChanges();
















        }
    }
}