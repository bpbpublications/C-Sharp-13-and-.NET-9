using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

// Define a compiled query
var findFarmsByLocation = EF.CompileQuery((FarmingContext db, string location) => db.Farms.Where(f => f.Location == location));
using (var context = new FarmingContext())
{
    // Execute the compiled query
    var texasFarms = findFarmsByLocation(context, "Texas").ToList();
    var californiaFarms = findFarmsByLocation(context, "California").ToList();
}