using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class Cat
  {
    public int CatId { get; set; }
    public string catName { get; set; }
    public string catGender { get; set; }
    public string catAge { get; set; }
    public string catBreed { get; set; }
    public string catDescription { get; set; }
  }
}