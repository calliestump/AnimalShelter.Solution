using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelter : DbContext
  {
    public AnimalShelter(DbContextOptions<AnimalShelter> options)
      : base (options)
    { 
    }

    public DbSet<Cat> Cats { get; set; }
    public DbSet<Dog> Dogs { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Cat>()
          .HasData(
            new Cat {CatId = 1, catName = "Sage", catGender="Female", catAge = "1 year, 5 months", catBreed = "Maine Coon/Mix", catDescription="Sage is a friendly cat that really enjoys being around people. She is very loving and will give you all the cuddles you desire."},
            new Cat {CatId = 2, catName = "Appa", catGender="Male", catAge = "8 months", catBreed = "Somali/Mix", catDescription="Appa is a fun energetic kitten that loves to play. Absolute sweetheart."},
            new Cat {CatId = 3, catName = "Bailey", catGender="Female", catAge = "9 years, 3 months", catBreed = "Domestic Shorthair/Mix", catDescription="Bailey is a sweet and gentle cat who would make an amazing companion."}
          );
      builder.Entity<Dog>()
          .HasData(
            new Dog {DogId = 1, dogName = "Joel", dogGender="Male", dogAge = "2 years, 1 month", dogBreed = "Great Dane/Mix", dogDescription="Joel is a sweetheart that absolutely loves to play. He is great with kids and is a perfect fit to make a family complete."},
            new Dog {DogId = 2, dogName = "Roswell", dogGender="Male", dogAge = "4 years, 3 months", dogBreed = "Pitbull, Terrier/Mix", dogDescription="Roswell is a fun energetic dog that loves to run around. He is a perfect dog to venture with and take on outdoor trips."},
            new Dog {DogId = 3, dogName = "Stone", dogGender="Female", dogAge = "10 years, 3 months", dogBreed = "Retriever, Labrador/Mix", dogDescription="Stone is an absolute sweetheart. She is very gentle with people and would make a perfect companion."}
          );
    }
  }
}