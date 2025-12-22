using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskForge.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TestClasses",
                columns: new[] { "Id", "Description", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "Seed user Alice", "alice@example.com", "Alice" },
                    { 2, "Seed user Bob", "bob@example.com", "Bob" },
                    { 3, "Seed user Charlie", "charlie@example.com", "Charlie" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TestClasses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TestClasses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TestClasses",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
