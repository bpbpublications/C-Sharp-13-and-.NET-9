using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class NurseriesController : ControllerBase
{
    private readonly INurseryRepository _repository;
    public NurseriesController(INurseryRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Nursery>>> GetAll()
    {
        return Ok(await _repository.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Nursery>> Get(int id)
    {
        var nursery = await _repository.GetByIdAsync(id);
        if (nursery == null)
        {
            return NotFound();
        }

        return Ok(nursery);
    }
}