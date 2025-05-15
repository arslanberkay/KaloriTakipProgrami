using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgrami.UI.Migrations
{
    /// <inheritdoc />
    public partial class m8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Yoneticiler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "KullaniciAdi", "Sifre" },
                values: new object[] { "berkay", "0606" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Yoneticiler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "KullaniciAdi", "Sifre" },
                values: new object[] { "berkay62", "berko6262" });
        }
    }
}
