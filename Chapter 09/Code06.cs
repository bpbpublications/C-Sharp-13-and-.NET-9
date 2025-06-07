using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main()
    {
        using (var context = new FarmingContext())
        {
            // Fetch all Farms that grow more than 3 types of Vegetables
            var farmsWithMultipleVegetables = context.Farms.Include(f => f.Vegetables).Where(f => f.Vegetables.Count > 3).ToList();
            // Fetch all Farms that are growing Carrots
            var farmsGrowingCarrots = context.Farms.Include(f => f.Vegetables).Where(f => f.Vegetables.Any(v => v.Name == "Carrot")).ToList();
            // Fetch the total quantity of all Crops grown in all Farms
            var totalCropQuantity = context.Crops.Sum(c => c.Quantity);
            // Output the results
            Console.WriteLine("Farms with multiple types of Vegetables:");
            foreach (var farm in farmsWithMultipleVegetables)
            {
                Console.WriteLine(farm.Name);
            }

            Console.WriteLine("\nFarms growing Carrots:");
            foreach (var farm in farmsGrowingCarrots)
            {
                Console.WriteLine(farm.Name);
            }

            Console.WriteLine($"\nTotal quantity of all Crops: {totalCropQuantity}");
        }
    }
}