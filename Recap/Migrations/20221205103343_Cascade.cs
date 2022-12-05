using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Recap.Migrations
{
    /// <inheritdoc />
    public partial class Cascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Places_PlaceLocation",
                table: "Characters");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Places_PlaceLocation",
                table: "Characters",
                column: "PlaceLocation",
                principalTable: "Places",
                principalColumn: "Location",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Places_PlaceLocation",
                table: "Characters");

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
                values: new object[] { "Rivendell", "Elven otherworld, also known as Imladris in Sindarin. Important place in Middle-earth." });

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Places_PlaceLocation",
                table: "Characters",
                column: "PlaceLocation",
                principalTable: "Places",
                principalColumn: "Location",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
