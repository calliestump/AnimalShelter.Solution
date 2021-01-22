using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class Dog
  {
    public int DogId { get; set; }


    [Required]
    [DisplayName("Dog Name")]
    [StringLength(20, ErrorMessage = "15 Characters max")]
    public string dogName { get; set; }


    [Required]
    [DisplayName("Dog Gender")]
    [StringLength(6, ErrorMessage = "6 Characters max")]
    public string dogGender { get; set; }


    [Required]
    [DisplayName("Dog Age")]
    [StringLength(25, ErrorMessage = "15 Characters max")]
    public string dogAge { get; set; }


    [Required]
    [DisplayName("Dog Breed")]
    [StringLength(50, ErrorMessage = "50 Characters max")]
    public string dogBreed { get; set; }


    [Required]
    [DisplayName("Dog Description")]
    [StringLength(500, ErrorMessage = "500 Characters max")]
    public string dogDescription { get; set; }
  }
}