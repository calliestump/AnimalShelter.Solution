using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class Other
  {
    public int OtherId { get; set; }


    [Required]
    [DisplayName("Name")]
    [StringLength(20, ErrorMessage = "20 Characters max")]
    public string otherName { get; set; }


    [Required]
    [DisplayName("Species")]
    [StringLength(20, ErrorMessage = "20 Characters max")]
    public string otherSpecies { get; set; }
    
    [Required]
    [DisplayName("Spayed/Neutrued (Yes/No/Unknown)")]
    [StringLength(7, ErrorMessage = "7 Characters max")]
    public string otherFixed { get; set; }


    [Required]
    [DisplayName("Gender")]
    [StringLength(6, ErrorMessage = "6 Characters max")]
    public string otherGender { get; set; }


    [Required]
    [DisplayName("Age")]
    [StringLength(25, ErrorMessage = "25 Characters max")]
    public string otherAge { get; set; }


    [Required]
    [DisplayName("Breed")]
    [StringLength(50, ErrorMessage = "50 Characters max")]
    public string otherBreed { get; set; }


    [Required]
    [DisplayName("Description")]
    [StringLength(500, ErrorMessage = "500 Characters max")]
    public string otherDescription { get; set; }
  }
}