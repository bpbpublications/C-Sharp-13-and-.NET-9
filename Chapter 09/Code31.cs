using (var context = new FarmingContext())
{
    var farm = context.Farms.Include(f => f.Crops) // Eager Loading: Crops are loaded along with Farm
    .First();
    var crops = farm.Crops; // No separate query, crops are already loaded
}