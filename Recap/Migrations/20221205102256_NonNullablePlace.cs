using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Recap.Migrations
{
    /// <inheritdoc />
    public partial class NonNullablePlace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Location",
                keyValue: "Rivendell");

            migrationBuilder.AlterColumn<string>(
                name: "PlaceLocation",
                table: "Characters",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PlaceLocation",
                table: "Characters",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "FirstName", "LastName", "Lineage", "PlaceLocation" },
                values: new object[,]
                {
                    { 1, "Boromir", "Son of Denethor", "Human", null },
                    { 2, "Legolas", "Greenleaf", "Elf", null },
                    { 3, "Frodo", "Baggins", "Halfling", null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Location", "Description" },
                values: new object[] { "Rivendell", "Rivendell, also known as Imladris in Sindarin, was an Elven town and the house of Elrond located in Middle - earth." });
        }
    }
}
