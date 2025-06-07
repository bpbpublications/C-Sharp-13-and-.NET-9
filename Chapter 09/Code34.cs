using (var context = new FarmingContext())
{
    // Adding multiple Farms
    var farm1 = new Farm
    {
        Name = "Green Farm",
        Location = "USA"
    };
    var farm2 = new Farm
    {
        Name = "Blue Farm",
        Location = "Canada"
    };
    context.Farms.AddRange(farm1, farm2);
    // Updating multiple Crops
    var crop1 = context.Crops.Find(1);
    var crop2 = context.Crops.Find(2);
    crop1.Name = "UpdatedCrop1";
    crop2.Name = "UpdatedCrop2";
    // Deleting a Crop
    var cropToDelete = new Crop
    {
        Id = 3
    };
    context.Crops.Remove(cropToDelete);
    // Executes Insert for farm1 and farm2, Update for crop1 and crop2, and Delete for cropToDelete in a single transaction
    context.SaveChanges();
}