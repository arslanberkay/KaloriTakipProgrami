using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgrami.UI.Migrations
{
    /// <inheritdoc />
    public partial class m6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Kilo",
                table: "KullaniciDetaylari",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Boy",
                table: "KullaniciDetaylari",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 1,
                column: "Boy",
                value: 1.98m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 2,
                column: "Boy",
                value: 1.78m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 3,
                column: "Boy",
                value: 1.91m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 4,
                column: "Boy",
                value: 1.73m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 5,
                column: "Boy",
                value: 1.80m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 6,
                column: "Boy",
                value: 1.50m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 7,
                column: "Boy",
                value: 1.90m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 8,
                column: "Boy",
                value: 1.98m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 9,
                column: "Boy",
                value: 1.78m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 10,
                column: "Boy",
                value: 1.72m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 11,
                column: "Boy",
                value: 1.82m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 12,
                column: "Boy",
                value: 1.77m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 13,
                column: "Boy",
                value: 1.98m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 14,
                column: "Boy",
                value: 1.90m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 15,
                column: "Boy",
                value: 1.86m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Kilo",
                table: "KullaniciDetaylari",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Boy",
                table: "KullaniciDetaylari",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 1,
                column: "Boy",
                value: 198.3m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 2,
                column: "Boy",
                value: 178.1m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 3,
                column: "Boy",
                value: 191.1m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 4,
                column: "Boy",
                value: 173.9m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 5,
                column: "Boy",
                value: 180.1m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 6,
                column: "Boy",
                value: 150.5m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 7,
                column: "Boy",
                value: 190.0m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 8,
                column: "Boy",
                value: 198.9m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 9,
                column: "Boy",
                value: 178.7m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 10,
                column: "Boy",
                value: 179.2m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 11,
                column: "Boy",
                value: 185.2m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 12,
                column: "Boy",
                value: 177.8m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 13,
                column: "Boy",
                value: 198.1m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 14,
                column: "Boy",
                value: 190.4m);

            migrationBuilder.UpdateData(
                table: "KullaniciDetaylari",
                keyColumn: "Id",
                keyValue: 15,
                column: "Boy",
                value: 186.2m);
        }
    }
}
