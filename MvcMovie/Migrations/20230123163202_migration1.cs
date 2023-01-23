using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Movie_PK", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "ID", "Genre", "Price", "Rating", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "Action", 10m, "Good", new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption" },
                    { 2, "Action", 10m, "Good", new DateTime(1972, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather" },
                    { 3, "Action", 10m, "Good", new DateTime(1974, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather: Part II" },
                    { 4, "Action", 10m, "Good", new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" },
                    { 5, "Comedy", 10m, "Good", new DateTime(1957, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Angry Men" },
                    { 6, "Horror", 10m, "Good", new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schindler's List" },
                    { 7, "Action", 10m, "Good", new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Return of the King" },
                    { 8, "Comedy", 10m, "Good", new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
