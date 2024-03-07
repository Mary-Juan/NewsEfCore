using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsEfCore.Migrations
{
    /// <inheritdoc />
    public partial class SeedNewsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Body", "CategoryId", "ImageName", "RegisterDate", "ShortDescription", "Title", "WriterId" },
                values: new object[] { 1, " hyjfughgtrdhtrdrtfg", 1, "0.png", new DateTime(2024, 3, 7, 0, 6, 37, 612, DateTimeKind.Local).AddTicks(5524), "htrdt", "Folan", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
