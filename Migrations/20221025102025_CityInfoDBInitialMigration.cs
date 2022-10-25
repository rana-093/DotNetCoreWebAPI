using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNetCoreWebAPI.Migrations
{
    public partial class CityInfoDBInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pointsOfInterests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pointsOfInterests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pointsOfInterests_cities_cityId",
                        column: x => x.cityId,
                        principalTable: "cities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_pointsOfInterests_cityId",
                table: "pointsOfInterests",
                column: "cityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pointsOfInterests");

            migrationBuilder.DropTable(
                name: "cities");
        }
    }
}
