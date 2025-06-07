using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class FarmApiController : ControllerBase
{
    private readonly FarmingContext _context;
    public FarmApiController(FarmingContext context)
    {
        _context = context;
    }

    // 1. API to List Markets by Fruits
    [HttpGet("MarketsByFruits/{fruitName}")]
    public async Task<ActionResult<IEnumerable<Market>>> GetMarketsByFruits(string fruitName)
    {
        var markets = await _context.Markets.Where(m => m.DistributionCenter.Markets.Any(dc => dc.Fruits.Any(f => f.Name == fruitName))).ToListAsync();
        return Ok(markets);
    }

    // 2. API to List DistributionCenters by Farms
    [HttpGet("DistributionCentersByFarms/{farmName}")]
    public async Task<ActionResult<IEnumerable<DistributionCenter>>> GetDistributionCentersByFarms(string farmName)
    {
        var centers = await _context.DistributionCenters.Where(dc => dc.Farms.Any(f => f.Name == farmName)).ToListAsync();
        return Ok(centers);
    }

    // 3. API to Return Total Sales by Fruit type
    [HttpGet("TotalSalesByFruit/{fruitName}")]
    public async Task<ActionResult<object>> GetTotalSalesByFruitType(string fruitName)
    {
        var totalSalesByFruit = await _context.Markets.Where(m => m.Fruits.Any(f => f.Name == fruitName)).Select(m => new { MarketName = m.Name, Farm = m.DistributionCenter.Farms.First(f => f.Fruits.Any(fr => fr.Name == fruitName)).Name, DistributionCenter = m.DistributionCenter.Location, TotalSales = m.Fruits.Where(f => f.Name == fruitName).Sum(f => f.Quantity) }).ToListAsync();
        return Ok(totalSalesByFruit);
    }
}