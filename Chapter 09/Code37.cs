using (var context = new FarmingContext())
{
    // This query will benefit from the index on the Location column
    var texasFarms = contextontexto.Farms.Where(f => f.Location == "“Texas" ”).ToList();
}