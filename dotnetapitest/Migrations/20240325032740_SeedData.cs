using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnetapitest.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Description", "ItemId1", "SKU" },
                values: new object[,]
                {
                    { 1, "Dining Table", null, 665544332 },
                    { 2, "Dining Table", null, 665544332 },
                    { 3, "Dining Table", null, 665544332 },
                    { 4, "Dining Table", null, 665544332 },
                    { 5, "Dining Table", null, 665544332 },
                    { 6, "Dining Table", null, 665544332 },
                    { 7, "Dining Table", null, 665544332 },
                    { 8, "Dining Table", null, 665544332 },
                    { 9, "Dining Table", null, 665544332 },
                    { 10, "Dining Table", null, 665544332 },
                    { 11, "Dining Chair", null, 665544331 },
                    { 12, "Dining Chair", null, 665544331 },
                    { 13, "Dining Chair", null, 665544331 },
                    { 14, "Dining Chair", null, 665544331 },
                    { 15, "Dining Chair", null, 665544331 },
                    { 16, "Dining Chair", null, 665544331 },
                    { 17, "Dining Chair", null, 665544331 },
                    { 18, "Dining Chair", null, 665544331 },
                    { 19, "Dining Chair", null, 665544331 },
                    { 20, "Dining Chair", null, 665544331 },
                    { 21, "Sofa", null, 665544333 },
                    { 22, "Sofa", null, 665544333 },
                    { 23, "Sofa", null, 665544333 },
                    { 24, "Sofa", null, 665544333 },
                    { 25, "Sofa", null, 665544333 },
                    { 26, "Sofa", null, 665544333 },
                    { 27, "Sofa", null, 665544333 },
                    { 28, "Sofa", null, 665544333 },
                    { 29, "Sofa", null, 665544333 },
                    { 30, "Sofa", null, 665544333 },
                    { 31, "Loveseat", null, 665544334 },
                    { 32, "Loveseat", null, 665544334 },
                    { 33, "Loveseat", null, 665544334 },
                    { 34, "Loveseat", null, 665544334 },
                    { 35, "Loveseat", null, 665544334 },
                    { 36, "Loveseat", null, 665544334 },
                    { 37, "Loveseat", null, 665544334 },
                    { 38, "Loveseat", null, 665544334 },
                    { 39, "Loveseat", null, 665544334 },
                    { 40, "Loveseat", null, 665544334 },
                    { 41, "Chair", null, 665544335 },
                    { 42, "Chair", null, 665544335 },
                    { 43, "Chair", null, 665544335 },
                    { 44, "Chair", null, 665544335 },
                    { 45, "Chair", null, 665544335 },
                    { 46, "Chair", null, 665544335 },
                    { 47, "Chair", null, 665544335 },
                    { 48, "Chair", null, 665544335 },
                    { 49, "Chair", null, 665544335 },
                    { 50, "Chair", null, 665544335 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 50);
        }
    }
}
