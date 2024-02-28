using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopTest.Migrations
{
    /// <inheritdoc />
    public partial class BreadValue100 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bread",
                keyColumn: "Id",
                keyValue: 1,
                column: "Count",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Bread",
                keyColumn: "Id",
                keyValue: 2,
                column: "Count",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Bread",
                keyColumn: "Id",
                keyValue: 3,
                column: "Count",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Bread",
                keyColumn: "Id",
                keyValue: 4,
                column: "Count",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Bread",
                keyColumn: "Id",
                keyValue: 5,
                column: "Count",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 1,
                column: "Weight",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 2,
                column: "Weight",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 3,
                column: "Weight",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 4,
                column: "Weight",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 5,
                column: "Weight",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Meat",
                keyColumn: "Id",
                keyValue: 1,
                column: "Weight",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Meat",
                keyColumn: "Id",
                keyValue: 2,
                column: "Weight",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Meat",
                keyColumn: "Id",
                keyValue: 3,
                column: "Weight",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Meat",
                keyColumn: "Id",
                keyValue: 4,
                column: "Weight",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Meat",
                keyColumn: "Id",
                keyValue: 5,
                column: "Weight",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Milk",
                keyColumn: "Id",
                keyValue: 1,
                column: "Count",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Milk",
                keyColumn: "Id",
                keyValue: 2,
                column: "Count",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Milk",
                keyColumn: "Id",
                keyValue: 3,
                column: "Count",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Milk",
                keyColumn: "Id",
                keyValue: 4,
                column: "Count",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Milk",
                keyColumn: "Id",
                keyValue: 5,
                column: "Count",
                value: 100);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bread",
                keyColumn: "Id",
                keyValue: 1,
                column: "Count",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Bread",
                keyColumn: "Id",
                keyValue: 2,
                column: "Count",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Bread",
                keyColumn: "Id",
                keyValue: 3,
                column: "Count",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Bread",
                keyColumn: "Id",
                keyValue: 4,
                column: "Count",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Bread",
                keyColumn: "Id",
                keyValue: 5,
                column: "Count",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 1,
                column: "Weight",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 2,
                column: "Weight",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 3,
                column: "Weight",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 4,
                column: "Weight",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 5,
                column: "Weight",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Meat",
                keyColumn: "Id",
                keyValue: 1,
                column: "Weight",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Meat",
                keyColumn: "Id",
                keyValue: 2,
                column: "Weight",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Meat",
                keyColumn: "Id",
                keyValue: 3,
                column: "Weight",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Meat",
                keyColumn: "Id",
                keyValue: 4,
                column: "Weight",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Meat",
                keyColumn: "Id",
                keyValue: 5,
                column: "Weight",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Milk",
                keyColumn: "Id",
                keyValue: 1,
                column: "Count",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Milk",
                keyColumn: "Id",
                keyValue: 2,
                column: "Count",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Milk",
                keyColumn: "Id",
                keyValue: 3,
                column: "Count",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Milk",
                keyColumn: "Id",
                keyValue: 4,
                column: "Count",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Milk",
                keyColumn: "Id",
                keyValue: 5,
                column: "Count",
                value: 1);
        }
    }
}
