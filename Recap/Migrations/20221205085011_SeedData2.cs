using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recap.Migrations
{
    /// <inheritdoc />
    public partial class SeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Location", "Description" },
                values: new object[] { "Rivendell", "Rivendell, also known as Imladris in Sindarin, was an Elven town and the house of Elrond located in Middle - earth." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Location",
                keyValue: "Rivendell");
        }
    }
}
