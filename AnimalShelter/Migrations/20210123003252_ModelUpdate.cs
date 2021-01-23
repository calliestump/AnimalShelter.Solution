using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class ModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "otherBreed",
                table: "Others",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Others",
                keyColumn: "OtherId",
                keyValue: 1,
                columns: new[] { "otherAge", "otherBreed", "otherDescription", "otherFixed", "otherName" },
                values: new object[] { "1 year", null, "Oreo is light in color and is very good with human contact. He really enjoys people.", "Unknown", "Oreo" });

            migrationBuilder.UpdateData(
                table: "Others",
                keyColumn: "OtherId",
                keyValue: 2,
                columns: new[] { "otherAge", "otherBreed", "otherFixed", "otherGender", "otherName" },
                values: new object[] { "3 years, 3 months", null, "Yes", "Female", "Smaug" });

            migrationBuilder.UpdateData(
                table: "Others",
                keyColumn: "OtherId",
                keyValue: 3,
                columns: new[] { "otherAge", "otherBreed", "otherDescription", "otherName" },
                values: new object[] { "2 years, 1 month", "Short Hair", "Bernie is darker in color and has beautiful silky fur. He loves to be around people and would make a perfect addition for a family.", "Bernie" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "otherBreed",
                table: "Others",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Others",
                keyColumn: "OtherId",
                keyValue: 1,
                columns: new[] { "otherAge", "otherBreed", "otherDescription", "otherFixed", "otherName" },
                values: new object[] { "2 years, 1 month", "Great Dane", "Joel is a sweetheart that absolutely loves to play. He is great with kids and is a perfect fit to make a family complete.", "No", "Joel" });

            migrationBuilder.UpdateData(
                table: "Others",
                keyColumn: "OtherId",
                keyValue: 2,
                columns: new[] { "otherAge", "otherBreed", "otherFixed", "otherGender", "otherName" },
                values: new object[] { "4 years, 3 months", "Pitbull, Terrier", "Unknown", "Male", "Roswell" });

            migrationBuilder.UpdateData(
                table: "Others",
                keyColumn: "OtherId",
                keyValue: 3,
                columns: new[] { "otherAge", "otherBreed", "otherDescription", "otherName" },
                values: new object[] { "10 years, 3 months", "Retriever, Labrador", "Stone is an absolute sweetheart. She is very gentle with people and would make a perfect companion.", "Stone" });
        }
    }
}
