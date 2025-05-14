using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgrami.UI.Migrations
{
    /// <inheritdoc />
    public partial class m4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KullaniciId", "Miktar", "OgunId", "Tarih", "YemekId" },
                values: new object[] { 1, 150m, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KullaniciId", "Miktar", "OgunId", "Tarih", "YemekId" },
                values: new object[] { 23, 192m, 2, new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 142 });
        }
    }
}
