using System.Collections.Generic;
using System.Threading.Tasks;
using AnimalShelterApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterApiContext _db;
    public AnimalsController(AnimalShelterApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get()
    {
      return await _db.Animals.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = animal.AnimalId }, animal);
    }
  }
}