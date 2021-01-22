using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public ActionResult<IEnumerable<Dog>> Get(string dogName, string dogGender, string dogAge, string dogBreed, string dogDescription)
    {
      var query = _db.Dogs.AsQueryable();

      if (dogName != null)
      {
        query = query.Where(entry => entry.dogName == dogName);
      }
      if (dogGender != null)
      {
        query = query.Where(entry => entry.dogGender == dogGender);
      }
      if (dogAge != null)
      {
        query = query.Where(entry => entry.dogAge == dogAge);
      }
      if (dogBreed != null)
      {
        query = query.Where(entry => entry.dogBreed == dogBreed);
      }
      if (dogDescription != null)
      {
        query = query.Where(entry => entry.dogDescription == dogDescription);
      }
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

    // PUT api/dogs/{id}
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Dog dog)
    {
      dog.DogId = id;
      _db.Entry(dog).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELTE api/dogs/{id}
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var dogToDelete = _db.Dogs.FirstOrDefault(entry => entry.DogId == id);
      _db.Dogs.Remove(dogToDelete);
      _db.SaveChanges();
    }
  }
}