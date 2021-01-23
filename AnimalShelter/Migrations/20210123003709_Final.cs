using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Others",
                keyColumn: "OtherId",
                keyValue: 2,
                column: "otherDescription",
                value: "Smaug has beautiful colors and loves to run around. He is a gorgeous bearded dragon and would make a great addition to a family.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Others",
                keyColumn: "OtherId",
                keyValue: 2,
                column: "otherDescription",
                value: "Roswell is a fun energetic dog that loves to run around. He is a perfect dog to venture with and take on outdoor trips.");
        }
    }
}
