using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recap.Migrations
{
    /// <inheritdoc />
    public partial class SetNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Places_PlaceLocation",
                table: "Characters");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Places_PlaceLocation",
                table: "Characters",
                column: "PlaceLocation",
                principalTable: "Places",
                principalColumn: "Location",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Places_PlaceLocation",
                table: "Characters");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Places_PlaceLocation",
                table: "Characters",
                column: "PlaceLocation",
                principalTable: "Places",
                principalColumn: "Location");
        }
    }
}
