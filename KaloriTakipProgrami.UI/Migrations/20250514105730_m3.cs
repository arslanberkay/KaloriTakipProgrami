using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgrami.UI.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OgunYemekler",
                columns: new[] { "Id", "KullaniciId", "Miktar", "OgunId", "Tarih", "YemekId" },
                values: new object[] { 1, 23, 192m, 2, new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 142 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
