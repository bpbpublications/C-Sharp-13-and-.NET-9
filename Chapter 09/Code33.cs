using (var context = new FarmingContext())
{
    // Query without tracking
    var nonTrackedFarm = context.Farms.AsNoTracking().First(f => f.Id == 1);
    // Even if you modify the entity, it won’t be saved back to the database
    nonTrackedFarm.Name = "Name Change Won’t Persist";
    // Save changes
    context.SaveChanges(); // No changes will be committed to the database
}