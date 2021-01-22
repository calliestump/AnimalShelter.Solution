using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class DogField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "dogFixed",
                table: "Dogs",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "catFixed",
                table: "Cats",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "catImage",
                table: "Cats",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 1,
                column: "catFixed",
                value: "Yes");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 2,
                column: "catFixed",
                value: "No");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 3,
                column: "catFixed",
                value: "Yes");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1,
                column: "dogFixed",
                value: "No");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2,
                column: "dogFixed",
                value: "Yes");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 3,
                column: "dogFixed",
                value: "Yes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dogFixed",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "catFixed",
                table: "Cats");

            migrationBuilder.DropColumn(
                name: "catImage",
                table: "Cats");
        }
    }
}
