using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class OtherFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "otherSpecies",
                table: "Others",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Others",
                columns: new[] { "OtherId", "otherAge", "otherBreed", "otherDescription", "otherFixed", "otherGender", "otherName", "otherSpecies" },
                values: new object[] { 1, "2 years, 1 month", "Great Dane", "Joel is a sweetheart that absolutely loves to play. He is great with kids and is a perfect fit to make a family complete.", "No", "Male", "Joel", "Rabbit" });

            migrationBuilder.InsertData(
                table: "Others",
                columns: new[] { "OtherId", "otherAge", "otherBreed", "otherDescription", "otherFixed", "otherGender", "otherName", "otherSpecies" },
                values: new object[] { 2, "4 years, 3 months", "Pitbull, Terrier", "Roswell is a fun energetic dog that loves to run around. He is a perfect dog to venture with and take on outdoor trips.", "Unknown", "Male", "Roswell", "Bearded Dragon" });

            migrationBuilder.InsertData(
                table: "Others",
                columns: new[] { "OtherId", "otherAge", "otherBreed", "otherDescription", "otherFixed", "otherGender", "otherName", "otherSpecies" },
                values: new object[] { 3, "10 years, 3 months", "Retriever, Labrador", "Stone is an absolute sweetheart. She is very gentle with people and would make a perfect companion.", "Yes", "Female", "Stone", "Rabbit" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Others",
                keyColumn: "OtherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Others",
                keyColumn: "OtherId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Others",
                keyColumn: "OtherId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "otherSpecies",
                table: "Others");
        }
    }
}
