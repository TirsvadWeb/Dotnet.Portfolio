using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Portfolio.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "PortfolioItem",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    SourceLink = table.Column<string>(type: "TEXT", maxLength: 2048, nullable: false),
                    GenreTags = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioItem", x => x.Guid);
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Guid", "Name" },
                values: new object[,]
                {
                    { new Guid("0936dd59-5f27-4efd-b415-05f0bb817ee2"), "Blazor" },
                    { new Guid("a5ab66c1-30d9-4773-8366-dad834af6bbd"), "c#" },
                    { new Guid("e3642c4e-db08-47fa-8757-5a62ada67edb"), "Python" }
                });

            migrationBuilder.InsertData(
                table: "PortfolioItem",
                columns: new[] { "Guid", "Description", "GenreTags", "Name", "SourceLink" },
                values: new object[] { new Guid("0577fbae-b2c8-4807-bb32-3c6f3e80af29"), "PortfolioItem", "[\"A5AB66C1-30D9-4773-8366-DAD834AF6BBD\",\"0936DD59-5F27-4EFD-B415-05F0BB817EE2\"]", "Portfolio Web application", "https://portfolio.tirsvad.dk/" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "PortfolioItem");
        }
    }
}
