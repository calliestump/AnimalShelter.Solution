using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
      : base (options)
    { 
    }

    public DbSet<Cat> Cats { get; set; }
    public DbSet<Dog> Dogs { get; set; }

    public DbSet<Other> Others { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Cat>()
          .HasData(
            new Cat {CatId = 1, catName = "Sage", catFixed= "Yes", catGender="Female", catAge = "1 year, 5 months", catBreed = "Maine Coon", catDescription="Sage is a friendly cat that really enjoys being around people. She is very loving and will give you all the cuddles you desire."},
            new Cat {CatId = 2, catName = "Appa", catFixed= "No", catGender="Male", catAge = "8 months", catBreed = "Somali", catDescription="Appa is a fun energetic kitten that loves to play. Absolute sweetheart."},
            new Cat {CatId = 3, catName = "Bailey", catFixed= "Yes", catGender="Female", catAge = "9 years, 3 months", catBreed = "Domestic Shorthair", catDescription="Bailey is a sweet and gentle cat who would make an amazing companion."}
          );
      builder.Entity<Dog>()
          .HasData(
            new Dog {DogId = 1, dogName = "Joel", dogFixed= "No", dogGender="Male", dogAge = "2 years, 1 month", dogBreed = "Great Dane", dogDescription="Joel is a sweetheart that absolutely loves to play. He is great with kids and is a perfect fit to make a family complete."},
            new Dog {DogId = 2, dogName = "Roswell", dogFixed= "Yes", dogGender="Male", dogAge = "4 years, 3 months", dogBreed = "Pitbull, Terrier", dogDescription="Roswell is a fun energetic dog that loves to run around. He is a perfect dog to venture with and take on outdoor trips."},
            new Dog {DogId = 3, dogName = "Stone", dogFixed= "Yes", dogGender="Female", dogAge = "10 years, 3 months", dogBreed = "Retriever, Labrador", dogDescription="Stone is an absolute sweetheart. She is very gentle with people and would make a perfect companion."}
          );
      builder.Entity<Other>()
          .HasData(
            new Other {OtherId = 1, otherName = "Oreo", otherSpecies = "Rabbit", otherFixed= "Unknown", otherGender="Male", otherAge = "1 year", otherDescription= "Oreo is light in color and is very good with human contact. He really enjoys people."},
            new Other {OtherId = 2, otherName = "Smaug", otherSpecies = "Bearded Dragon", otherFixed= "Yes", otherGender="Female", otherAge = "3 years, 3 months", otherDescription="Smaug has beautiful colors and loves to run around. He is a gorgeous bearded dragon and would make a great addition to a family."},
            new Other {OtherId = 3, otherName = "Bernie", otherSpecies = "Rabbit", otherFixed= "Yes", otherGender="Female", otherAge = "2 years, 1 month", otherBreed = "Short Hair", otherDescription= "Bernie is darker in color and has beautiful silky fur. He loves to be around people and would make a perfect addition for a family."}
          );
    }
  }
}