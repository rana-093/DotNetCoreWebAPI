using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNetCoreWebAPI.Migrations
{
    public partial class CityInfoDBPopulate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "Id", "Name", "description" },
                values: new object[] { 1, "Dhaka", "Oldest city in BD" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "Id", "Name", "description" },
                values: new object[] { 2, "Ctg", "Port City" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "Id", "Name", "description" },
                values: new object[] { 3, "Sylhet", "Peaceful city ever" });

            migrationBuilder.InsertData(
                table: "pointsOfInterests",
                columns: new[] { "Id", "Name", "cityId" },
                values: new object[,]
                {
                    { 1, "Khilkhet", 1 },
                    { 2, "Uttara", 1 },
                    { 3, "Halisohor", 2 },
                    { 4, "Hobigonj", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "pointsOfInterests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "pointsOfInterests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "pointsOfInterests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "pointsOfInterests",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
