using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using System;




namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class OthersController : ControllerBase
  {
    private AnimalShelterContext _db;
    public OthersController(AnimalShelterContext db)
    {
      _db = db;
    }

    // GET api/others
    [HttpGet]
    public ActionResult<IEnumerable<Other>> Get(string otherName, string otherGender, string otherAge, string otherBreed, string otherDescription)
    {
      var query = _db.Others.AsQueryable();

      if (otherName != null)
      {
        query = query.Where(entry => entry.otherName == otherName);
      }
      if (otherGender != null)
      {
        query = query.Where(entry => entry.otherGender == otherGender);
      }
      if (otherAge != null)
      {
        query = query.Where(entry => entry.otherAge == otherAge);
      }
      if (otherBreed != null)
      {
        query = query.Where(entry => entry.otherBreed == otherBreed);
      }
      if (otherDescription != null)
      {
        query = query.Where(entry => entry.otherDescription == otherDescription);
      }
      return _db.Others.ToList();
    }
    // POST api/others
    [HttpPost]
    public void Post([FromBody] Other other)
    {
      _db.Others.Add(other);
      _db.SaveChanges();
    }

    // GET api/others/{id}
    [HttpGet("{id}")]
    public ActionResult<Other> GetAction(int id)
    {
      return _db.Others.FirstOrDefault(entry => entry.OtherId == id);
    }

    // PUT api/others/{id}
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Other other)
    {
      other.OtherId = id;
      _db.Entry(other).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELTE api/others/{id}
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var otherToDelete = _db.Others.FirstOrDefault(entry => entry.OtherId == id);
      _db.Others.Remove(otherToDelete);
      _db.SaveChanges();
    }

    //RANDOM api/others/random
    [HttpGet]
    [Route("random")]
    public ActionResult<Other> Random()
    {
        Random random = new Random();
        int randomOther = random.Next(_db.Others.ToList().Count);
        return _db.Others.FirstOrDefault(entry => entry.OtherId == randomOther);
    }
  }
}