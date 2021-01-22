using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CatsController : ControllerBase
  {
    private AnimalShelterContext _db;
    public CatsController(AnimalShelterContext db)
    {
      _db = db;
    }

    // GET api/cats
    [HttpGet]
    public ActionResult<IEnumerable<Cat>> Get(string catName, string catGender, string catAge, string catBreed, string catDescription)
    {
      var query = _db.Cats.AsQueryable();

      if (catName != null)
      {
        query = query.Where(entry => entry.catName == catName);
      }
      if (catGender != null)
      {
        query = query.Where(entry => entry.catGender == catGender);
      }
      if (catAge != null)
      {
        query = query.Where(entry => entry.catAge == catAge);
      }
      if (catBreed != null)
      {
        query = query.Where(entry => entry.catBreed == catBreed);
      }
      if (catDescription != null)
      {
        query = query.Where(entry => entry.catDescription == catDescription);
      }
      return query.ToList();
    }

    // POST api/cats
    [HttpPost]
    public void Post([FromBody] Cat cat)
    {
      _db.Cats.Add(cat);
      _db.SaveChanges();
    }

    // GET api/cats/{id}
    [HttpGet("{id}")]
    public ActionResult<Cat> GetAction(int id)
    {
      return _db.Cats.FirstOrDefault(entry => entry.CatId == id);
    }

    // PUT api/cats/{id}
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Cat cat)
    {
      cat.CatId = id;
      _db.Entry(cat).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELTE api/cats/{id}
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var catToDelete = _db.Cats.FirstOrDefault(entry => entry.CatId == id);
      _db.Cats.Remove(catToDelete);
      _db.SaveChanges();
    }
  }

}