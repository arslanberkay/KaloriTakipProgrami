using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KaloriTakipProgrami.UI.Migrations
{
    /// <inheritdoc />
    public partial class m5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.InsertData(
                table: "OgunYemekler",
                columns: new[] { "Id", "KullaniciId", "Miktar", "OgunId", "Tarih", "YemekId" },
                values: new object[,]
                {
                    { 2, 1, 200m, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, 1, 180m, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, 2, 100m, 1, new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, 2, 220m, 2, new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 6, 2, 170m, 3, new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 7, 29, 198m, 3, new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 148 },
                    { 8, 30, 199m, 4, new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 149 },
                    { 9, 1, 50m, 5, new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { 10, 2, 51m, 1, new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 151 },
                    { 11, 3, 52m, 2, new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 152 },
                    { 12, 4, 53m, 3, new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 153 },
                    { 13, 5, 54m, 4, new DateTime(2025, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 154 },
                    { 14, 6, 55m, 5, new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 155 },
                    { 15, 7, 56m, 1, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 156 },
                    { 16, 8, 57m, 2, new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 157 },
                    { 17, 9, 58m, 3, new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 158 },
                    { 18, 10, 59m, 4, new DateTime(2025, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 159 },
                    { 19, 11, 60m, 5, new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 160 },
                    { 20, 12, 61m, 1, new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 161 },
                    { 21, 13, 62m, 2, new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 162 },
                    { 22, 14, 63m, 3, new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 163 },
                    { 23, 15, 64m, 4, new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 164 },
                    { 24, 16, 65m, 5, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 165 },
                    { 25, 17, 66m, 1, new DateTime(2025, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 166 },
                    { 26, 18, 67m, 2, new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 167 },
                    { 27, 19, 68m, 3, new DateTime(2025, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 168 },
                    { 28, 20, 69m, 4, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 169 },
                    { 29, 21, 70m, 5, new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 170 },
                    { 50, 12, 91m, 1, new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 191 },
                    { 51, 13, 92m, 2, new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 192 },
                    { 52, 14, 93m, 3, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 193 },
                    { 53, 15, 94m, 4, new DateTime(2025, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 194 },
                    { 54, 16, 95m, 5, new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 195 },
                    { 55, 17, 96m, 1, new DateTime(2025, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 196 },
                    { 56, 18, 97m, 2, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 197 },
                    { 57, 19, 98m, 3, new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 198 },
                    { 58, 20, 99m, 4, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 199 },
                    { 59, 21, 100m, 5, new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 200 },
                    { 60, 22, 101m, 1, new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 201 },
                    { 61, 23, 102m, 2, new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 202 },
                    { 62, 24, 103m, 3, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 203 },
                    { 63, 25, 104m, 4, new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 204 },
                    { 64, 26, 105m, 5, new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 205 },
                    { 65, 27, 106m, 1, new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 206 },
                    { 66, 28, 107m, 2, new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 207 },
                    { 67, 29, 108m, 3, new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 208 },
                    { 68, 30, 109m, 4, new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 209 },
                    { 69, 1, 110m, 5, new DateTime(2025, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 210 },
                    { 70, 2, 111m, 1, new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 211 },
                    { 71, 3, 112m, 2, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 212 },
                    { 72, 4, 113m, 3, new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 213 },
                    { 73, 5, 114m, 4, new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 214 },
                    { 74, 6, 115m, 5, new DateTime(2025, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 215 },
                    { 75, 7, 116m, 1, new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 216 },
                    { 76, 8, 117m, 2, new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 217 },
                    { 77, 9, 118m, 3, new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 218 },
                    { 78, 10, 119m, 4, new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 219 },
                    { 79, 11, 120m, 5, new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 220 },
                    { 80, 12, 121m, 1, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 221 },
                    { 81, 13, 122m, 2, new DateTime(2025, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 222 },
                    { 82, 14, 123m, 3, new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 223 },
                    { 83, 15, 124m, 4, new DateTime(2025, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 224 },
                    { 84, 16, 125m, 5, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 225 },
                    { 85, 17, 126m, 1, new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 226 },
                    { 86, 18, 127m, 2, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 227 },
                    { 87, 19, 128m, 3, new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 228 },
                    { 88, 20, 129m, 4, new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 229 },
                    { 89, 21, 130m, 5, new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 230 },
                    { 90, 22, 131m, 1, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 201 },
                    { 91, 23, 132m, 2, new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 92, 24, 133m, 3, new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 93, 25, 134m, 4, new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 88 },
                    { 94, 26, 135m, 5, new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 63 },
                    { 95, 27, 136m, 1, new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 51 },
                    { 96, 28, 137m, 2, new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 88 },
                    { 97, 29, 138m, 3, new DateTime(2025, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 77 },
                    { 98, 30, 139m, 4, new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 71 },
                    { 99, 1, 140m, 5, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 74 },
                    { 100, 2, 141m, 1, new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 61 },
                    { 101, 3, 142m, 2, new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 161 },
                    { 102, 4, 143m, 3, new DateTime(2025, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 157 },
                    { 103, 5, 144m, 4, new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 104, 6, 145m, 5, new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 },
                    { 105, 7, 146m, 1, new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 156 },
                    { 106, 8, 147m, 2, new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 107, 9, 148m, 3, new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 108, 10, 149m, 4, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 84 },
                    { 109, 11, 150m, 5, new DateTime(2025, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 102 },
                    { 110, 12, 51m, 1, new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 111, 13, 52m, 2, new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 112, 14, 53m, 3, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 113, 15, 54m, 4, new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 114, 16, 55m, 5, new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 115, 17, 56m, 1, new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 116, 18, 57m, 2, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 117, 19, 58m, 3, new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 118, 20, 59m, 4, new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 119, 21, 60m, 5, new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 120, 22, 61m, 1, new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 121, 23, 62m, 2, new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 122, 24, 63m, 3, new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 123, 25, 64m, 4, new DateTime(2025, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 124, 26, 65m, 5, new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 125, 27, 66m, 1, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 126, 28, 67m, 2, new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 127, 29, 68m, 3, new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 128, 30, 69m, 4, new DateTime(2025, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 129, 1, 70m, 5, new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 130, 2, 71m, 1, new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 131, 3, 72m, 2, new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 132, 4, 73m, 3, new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 133, 5, 74m, 4, new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 134, 6, 75m, 5, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 135, 7, 76m, 1, new DateTime(2025, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 136, 8, 77m, 2, new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 137, 9, 78m, 3, new DateTime(2025, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 138, 10, 79m, 4, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 139, 11, 80m, 5, new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 140, 12, 81m, 1, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 141, 13, 82m, 2, new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 142, 14, 83m, 3, new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 },
                    { 143, 15, 84m, 4, new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 144, 16, 85m, 5, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 145, 17, 86m, 1, new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 146, 18, 87m, 2, new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 37 },
                    { 147, 19, 88m, 3, new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 148, 20, 89m, 4, new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 },
                    { 149, 21, 90m, 5, new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 150, 22, 91m, 1, new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 },
                    { 151, 23, 92m, 2, new DateTime(2025, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 152, 24, 93m, 3, new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 153, 25, 94m, 4, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 },
                    { 154, 26, 95m, 5, new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 155, 27, 96m, 1, new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 156, 28, 97m, 2, new DateTime(2025, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 },
                    { 157, 29, 98m, 3, new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 },
                    { 158, 30, 99m, 4, new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 },
                    { 159, 1, 100m, 5, new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 }
                });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 180m, 8, "Midye Dolma" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 220m, 8, "Midye Tava" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 250m, 8, "Ciğer Tava" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 200m, 8, "Çiğ Köfte" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 300m, 8, "Patates Kızartması" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 280m, 8, "Soğan Halkası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 260m, 8, "Patates Kroket" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 290m, 8, "Parmak Patates" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 240m, 8, "Peynirli Çubuk" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 180m, 8, "Humus" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 80m, 8, "Cacık" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 150m, 8, "Kısır Topları" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "KategoriId", "YemekAdi" },
                values: new object[] { 8, "Patlıcan Mücveri" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 200m, 8, "Mücver" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 360m, 8, "Sigara Böreği" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 380m, 8, "Peynirli Börek" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 370m, 8, "Ispanaklı Börek" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 390m, 8, "Paçanga Böreği" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 330m, 8, "Lavaş Pizza" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 500m, 8, "Kumpir" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 450m, "Tavuk Nugget" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 340m, "Mini Börek Çeşitleri" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 213,
                column: "YemekAdi",
                value: "Mini Köfte");

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 300m, "Mozzarella Stick" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 280m, "Soğan Halkası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 320m, "Patates Cipsi" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 250m, "Tuzlu Çekirdek" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 260m, "Kabak Çekirdeği" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 300m, "Antep Fıstığı" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 185m, "Ceviz" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 165m, "Badem" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 180m, "Fındık" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 310m, "Cips" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 100m, "Patlamış Mısır" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 270m, "Simit" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 320m, "Poğaça" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 410m, "Mini Pizza" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 450m, "Mini Hamburger" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 360m, "Atıştırmalık Tabağı" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 340m, "Çerez Tabağı" });

            migrationBuilder.InsertData(
                table: "Yemekler",
                columns: new[] { "Id", "Kalori", "KategoriId", "YemekAdi" },
                values: new object[,]
                {
                    { 171, 120m, 7, "Çoban Salatası" },
                    { 172, 140m, 7, "Gavurdağı Salatası" },
                    { 173, 100m, 7, "Roka Salatası" },
                    { 174, 130m, 7, "Akdeniz Salatası" },
                    { 175, 220m, 7, "Tavuklu Salata" },
                    { 176, 200m, 7, "Ton Balıklı Salata" },
                    { 177, 180m, 7, "Enginar Salatası" },
                    { 178, 160m, 7, "Patlıcan Salatası" },
                    { 179, 150m, 7, "Şakşuka" },
                    { 180, 170m, 7, "Yoğurtlu Semizotu Salatası" },
                    { 181, 190m, 7, "Yeşil Mercimek Salatası" },
                    { 182, 200m, 7, "Nohut Salatası" },
                    { 183, 210m, 7, "Kısır" },
                    { 184, 230m, 7, "Patates Salatası" },
                    { 185, 240m, 7, "Makarna Salatası" },
                    { 186, 180m, 7, "Pancar Salatası" },
                    { 187, 170m, 7, "Turp Salatası" },
                    { 188, 200m, 7, "Bulgur Pilavı Salatası" },
                    { 189, 220m, 7, "Peynirli Salata" },
                    { 190, 150m, 7, "Sebze Salatası" }
                });

            migrationBuilder.InsertData(
                table: "OgunYemekler",
                columns: new[] { "Id", "KullaniciId", "Miktar", "OgunId", "Tarih", "YemekId" },
                values: new object[,]
                {
                    { 30, 22, 71m, 1, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 171 },
                    { 31, 23, 72m, 2, new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 172 },
                    { 32, 24, 73m, 3, new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 173 },
                    { 33, 25, 74m, 4, new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 174 },
                    { 34, 26, 75m, 5, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 175 },
                    { 35, 27, 76m, 1, new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 176 },
                    { 36, 28, 77m, 2, new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 177 },
                    { 37, 29, 78m, 3, new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 178 },
                    { 38, 30, 79m, 4, new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 179 },
                    { 39, 1, 80m, 5, new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 180 },
                    { 40, 2, 81m, 1, new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 181 },
                    { 41, 3, 82m, 2, new DateTime(2025, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 182 },
                    { 42, 4, 83m, 3, new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 183 },
                    { 43, 5, 84m, 4, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 184 },
                    { 44, 6, 85m, 5, new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 185 },
                    { 45, 7, 86m, 1, new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 186 },
                    { 46, 8, 87m, 2, new DateTime(2025, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 187 },
                    { 47, 9, 88m, 3, new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 188 },
                    { 48, 10, 89m, 4, new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 189 },
                    { 49, 11, 90m, 5, new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 190 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "OgunYemekler",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 120m, 7, "Çoban Salatası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 140m, 7, "Gavurdağı Salatası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 100m, 7, "Roka Salatası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 130m, 7, "Akdeniz Salatası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 220m, 7, "Tavuklu Salata" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 200m, 7, "Ton Balıklı Salata" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 180m, 7, "Enginar Salatası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 160m, 7, "Patlıcan Salatası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 150m, 7, "Şakşuka" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 170m, 7, "Yoğurtlu Semizotu Salatası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 190m, 7, "Yeşil Mercimek Salatası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 200m, 7, "Nohut Salatası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "KategoriId", "YemekAdi" },
                values: new object[] { 7, "Kısır" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 230m, 7, "Patates Salatası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 240m, 7, "Makarna Salatası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 180m, 7, "Pancar Salatası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 170m, 7, "Turp Salatası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 200m, 7, "Bulgur Pilavı Salatası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 220m, 7, "Peynirli Salata" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Kalori", "KategoriId", "YemekAdi" },
                values: new object[] { 150m, 7, "Sebze Salatası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 180m, "Midye Dolma" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 220m, "Midye Tava" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 213,
                column: "YemekAdi",
                value: "Ciğer Tava");

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 200m, "Çiğ Köfte" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 300m, "Patates Kızartması" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 280m, "Soğan Halkası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 260m, "Patates Kroket" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 290m, "Parmak Patates" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 240m, "Peynirli Çubuk" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 180m, "Humus" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 80m, "Cacık" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 150m, "Kısır Topları" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 210m, "Patlıcan Mücveri" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 200m, "Mücver" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 360m, "Sigara Böreği" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 380m, "Peynirli Börek" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 370m, "Ispanaklı Börek" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 390m, "Paçanga Böreği" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 330m, "Lavaş Pizza" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 500m, "Kumpir" });

            migrationBuilder.InsertData(
                table: "Yemekler",
                columns: new[] { "Id", "Kalori", "KategoriId", "YemekAdi" },
                values: new object[,]
                {
                    { 231, 450m, 8, "Tavuk Nugget" },
                    { 232, 340m, 8, "Mini Börek Çeşitleri" },
                    { 233, 250m, 8, "Mini Köfte" },
                    { 234, 300m, 8, "Mozzarella Stick" },
                    { 235, 280m, 8, "Soğan Halkası" },
                    { 236, 320m, 8, "Patates Cipsi" },
                    { 237, 250m, 8, "Tuzlu Çekirdek" },
                    { 238, 260m, 8, "Kabak Çekirdeği" },
                    { 239, 300m, 8, "Antep Fıstığı" },
                    { 240, 185m, 8, "Ceviz" },
                    { 241, 165m, 8, "Badem" },
                    { 242, 180m, 8, "Fındık" },
                    { 243, 310m, 8, "Cips" },
                    { 244, 100m, 8, "Patlamış Mısır" },
                    { 245, 270m, 8, "Simit" },
                    { 246, 320m, 8, "Poğaça" },
                    { 247, 410m, 8, "Mini Pizza" },
                    { 248, 450m, 8, "Mini Hamburger" },
                    { 249, 360m, 8, "Atıştırmalık Tabağı" },
                    { 250, 340m, 8, "Çerez Tabağı" }
                });
        }
    }
}
