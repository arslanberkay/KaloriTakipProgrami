using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgrami.UI.Migrations
{
    /// <inheritdoc />
    public partial class m7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "KullaniciDetaylari",
                columns: new[] { "Id", "Boy", "Kilo", "KullaniciId", "Tarih" },
                values: new object[] { 16, 1.78m, 90.2m, 1, new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
