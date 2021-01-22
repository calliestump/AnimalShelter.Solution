using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class Dog
  {
    public int DogId { get; set; }
    public string dogName { get; set; }
    public string dogGender { get; set; }
    public string dogAge { get; set; }
    public string dogBreed { get; set; }
    public string dogDescription { get; set; }
  }
}