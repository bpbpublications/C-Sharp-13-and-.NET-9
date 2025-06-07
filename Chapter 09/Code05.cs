using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main()
    {
        using (var db = new FarmingContext())
        {
            // Initialize a new Farm
            var farm = new Farm
            {
                Name = "Green Valley"
            };
            db.Farms.Add(farm);
            // Add some crops
            var vegetable = new Vegetable
            {
                Type = "Carrot",
                Variety = "Nantes",
                PlantingDate = DateTime.Now.AddMonths(-2),
                HarvestDate = DateTime.Now.AddMonths(1),
                Farm = farm
            };
            var rice = new Rice
            {
                Grade = "Basmati",
                Variety = "White",
                PlantingDate = DateTime.Now.AddMonths(-3),
                HarvestDate = DateTime.Now.AddMonths(3),
                Farm = farm
            };
            var bean = new Bean
            {
                Color = "Black",
                Variety = "Black Bean",
                PlantingDate = DateTime.Now.AddMonths(-1),
                HarvestDate = DateTime.Now.AddMonths(2),
                Farm = farm
            };
            db.AddRange(vegetable, rice, bean);
            db.SaveChanges();
            // List all Farms
            Console.WriteLine("Farms:");
            var farms = db.Farms.Include(f => f.Crops).ToList();
            foreach (var f in farms)
            {
                Console.WriteLine($"- {f.Name}");
                foreach (var crop in f.Crops)
                {
                    Console.WriteLine($"  - {crop.Variety} ({crop.GetType().Name}), Planted on: {crop.PlantingDate}, Harvest on: {crop.HarvestDate}");
                }
            }

            // Delete a crop
            Console.WriteLine("Deleting the first crop...");
            var firstCrop = db.Crops.First();
            db.Crops.Remove(firstCrop);
            db.SaveChanges();
        }
    }
}