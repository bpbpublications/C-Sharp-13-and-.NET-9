using (var context = new FarmingContext())
{
    // Using projection to fetch only Id and Name fields from the Farm table
    var farms = context.Farms.Select(f => new { f.Id, f.Name }).ToList();
}