using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class Cat
  {
    public int CatId { get; set; }
    
    [Required]
    [DisplayName("Spayed/Neutrued (Yes/No)")]
    [StringLength(3, ErrorMessage = "3 Characters max")]
    public string catFixed { get; set; }


    [Required]
    [DisplayName("Cat Name")]
    [StringLength(20, ErrorMessage = "15 Characters max")]
    public string catName { get; set; }


    [Required]
    [DisplayName("Cat Gender")]
    [StringLength(6, ErrorMessage = "6 Characters max")]
    public string catGender { get; set; }


    [Required]
    [DisplayName("Cat Age")]
    [StringLength(25, ErrorMessage = "15 Characters max")]
    public string catAge { get; set; }


    [Required]
    [DisplayName("Cat Breed")]
    [StringLength(50, ErrorMessage = "20 Characters max")]
    public string catBreed { get; set; }


    [Required]
    [DisplayName("Cat Description")]
    [StringLength(500, ErrorMessage = "500 Characters max")]
    public string catDescription { get; set; }
  }
}