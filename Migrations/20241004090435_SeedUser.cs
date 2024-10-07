using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrialRazor.Migrations
{
    /// <inheritdoc />
    public partial class SeedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1988b2e8-9cec-4fd6-a129-f8f9ea469fb9", null, "Administrator", "ADMINISTRATOR" },
                    { "394180ad-fc26-444b-93ad-16672f8b6e93", null, "Super Administrator", "SUPER ADMINISTRATOR" },
                    { "bb92bca3-1945-4db9-a7c5-e0808c25bf83", null, "User", "USER" },
                    { "c25c4adb-0672-40c6-a623-f1816a0eae5c", null, "Maintainer", "MAINTAINER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1988b2e8-9cec-4fd6-a129-f8f9ea469fb9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "394180ad-fc26-444b-93ad-16672f8b6e93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb92bca3-1945-4db9-a7c5-e0808c25bf83");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c25c4adb-0672-40c6-a623-f1816a0eae5c");
        }
    }
}
