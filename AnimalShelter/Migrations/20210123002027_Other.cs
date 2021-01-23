using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Other : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Others",
                columns: table => new
                {
                    OtherId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    otherName = table.Column<string>(maxLength: 20, nullable: false),
                    otherFixed = table.Column<string>(maxLength: 7, nullable: false),
                    otherGender = table.Column<string>(maxLength: 6, nullable: false),
                    otherAge = table.Column<string>(maxLength: 25, nullable: false),
                    otherBreed = table.Column<string>(maxLength: 50, nullable: false),
                    otherDescription = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Others", x => x.OtherId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Others");
        }
    }
}
