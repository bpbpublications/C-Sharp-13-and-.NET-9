using (var context = new FarmingContext())
{
    // Query with tracking (default behavior)
    var trackedFarm = context.Farms.First(f => f.Id == 1);
    // Modify the entity
    trackedFarm.Name = "Updated Farm Name";
    // Save changes
    context.SaveChanges();
}