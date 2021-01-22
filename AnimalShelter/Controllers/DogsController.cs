using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DogsController : ControllerBase
  {
    private AnimalShelterContext _db;
    public DogsController(AnimalShelterContext db)
    {
      _db = db;
    }
    // GET api/dogs
    [HttpGet]
    public ActionResult<IEnumerable<Dog>> Get()
    {
      return _db.Dogs.ToList();
    }
    // POST api/dogs
    [HttpPost]
    public void Post([FromBody] Dog dog)
    {
      _db.Dogs.Add(dog);
      _db.SaveChanges();
    }

    // GET api/dogs/{id}
    [HttpGet("{id}")]
    public ActionResult<Dog> GetAction(int id)
    {
      return _db.Dogs.FirstOrDefault(entry => entry.DogId == id);
    }
  }
}