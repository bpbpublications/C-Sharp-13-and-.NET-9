using (var context = new FarmingContext())
{
    // Filtering: Get all farms located in "Texas"
    var texasFarms = context.Farms.Where(f => f.Location == "Texas").ToList();
    // Paging: Get the first page of farms with 5 farms per page
    int pageSize = 5;
    int pageNumber = 1; // Starting with the first page
    var pagedFarms = context.Farms.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
}