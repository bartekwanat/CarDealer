using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CarDealer.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CarDealerContext(
                serviceProvider.GetRequiredService<DbContextOptions<CarDealerContext>>()))
            {
                if (context.Car.Any())
                {
                    return;
                }

                context.Car.AddRange(
                    new Car
                    {
                        Brand = "BMW",
                        Model = "5",
                        Type = "Sedan/Limousine",
                        Mileage = 272000,
                        Capacity = 2999,
                        ProductionYear = DateTime.Parse("2006-5-16"),
                        HorsePower = 235,
                        Price = 12000
                    },

                    new Car
                    {
                        Brand = "Audi",
                        Model = "RS6",
                        Type = "Combi",
                        Mileage = 12000,
                        Capacity = 4000,
                        ProductionYear = DateTime.Parse("2019-1-4"),
                        HorsePower = 600,
                        Price = 200000
                    },

                    new Car
                    {
                        Brand = "Mercedes",
                        Model = "S",
                        Type = "Sedan/Limousine",
                        Mileage = 105700,
                        Capacity = 6300,
                        ProductionYear = DateTime.Parse("2018-5-12"),
                        HorsePower = 615,
                        Price = 128000
                    },



                    new Car
                    {
                        Brand = "BMW",
                        Model = "M760li",
                        Type = "Sedan/Limousine",
                        Mileage = 1700,
                        Capacity = 6592,
                        ProductionYear = DateTime.Parse("2021-1-06"),
                        HorsePower = 610,
                        Price = 250000
                    }
                    );
                
                context.SaveChanges();
            }


        }
    }
}
