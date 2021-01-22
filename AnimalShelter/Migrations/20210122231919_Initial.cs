using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    CatId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    catName = table.Column<string>(maxLength: 20, nullable: false),
                    catGender = table.Column<string>(maxLength: 6, nullable: false),
                    catAge = table.Column<string>(maxLength: 25, nullable: false),
                    catBreed = table.Column<string>(maxLength: 50, nullable: false),
                    catDescription = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    DogId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dogName = table.Column<string>(maxLength: 20, nullable: false),
                    dogGender = table.Column<string>(maxLength: 6, nullable: false),
                    dogAge = table.Column<string>(maxLength: 25, nullable: false),
                    dogBreed = table.Column<string>(maxLength: 50, nullable: false),
                    dogDescription = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.DogId);
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "catAge", "catBreed", "catDescription", "catGender", "catName" },
                values: new object[,]
                {
                    { 1, "1 year, 5 months", "Maine Coon", "Sage is a friendly cat that really enjoys being around people. She is very loving and will give you all the cuddles you desire.", "Female", "Sage" },
                    { 2, "8 months", "Somali", "Appa is a fun energetic kitten that loves to play. Absolute sweetheart.", "Male", "Appa" },
                    { 3, "9 years, 3 months", "Domestic Shorthair", "Bailey is a sweet and gentle cat who would make an amazing companion.", "Female", "Bailey" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "dogAge", "dogBreed", "dogDescription", "dogGender", "dogName" },
                values: new object[,]
                {
                    { 1, "2 years, 1 month", "Great Dane", "Joel is a sweetheart that absolutely loves to play. He is great with kids and is a perfect fit to make a family complete.", "Male", "Joel" },
                    { 2, "4 years, 3 months", "Pitbull, Terrier", "Roswell is a fun energetic dog that loves to run around. He is a perfect dog to venture with and take on outdoor trips.", "Male", "Roswell" },
                    { 3, "10 years, 3 months", "Retriever, Labrador", "Stone is an absolute sweetheart. She is very gentle with people and would make a perfect companion.", "Female", "Stone" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "Dogs");
        }
    }
}
