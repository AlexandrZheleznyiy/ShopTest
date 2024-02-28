using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopTest.Migrations
{
    /// <inheritdoc />
    public partial class AddClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Product_Store_Id",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Meat",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Fish",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Phone_Store",
                table: "Store",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name_Store",
                table: "Store",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email_Store",
                table: "Store",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Address_Store",
                table: "Store",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductStore_Id",
                table: "Milk",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Name_Prod",
                table: "Milk",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Department_Id",
                table: "Milk",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ProductStore_Id",
                table: "Meat",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Name_Prod",
                table: "Meat",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Department_Id",
                table: "Meat",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ProductStore_Id",
                table: "Managers",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Managers",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Managers",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Managers",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Managers",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Department_Id",
                table: "Managers",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Managers",
                type: "integer",
                nullable: true,
                defaultValue: 18,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductStore_Id",
                table: "Fish",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Name_Prod",
                table: "Fish",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Department_Id",
                table: "Fish",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Name_Department",
                table: "Department",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductStore_Id",
                table: "Department",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductStore_Id",
                table: "Bread",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Name_Prod",
                table: "Bread",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Department_Id",
                table: "Bread",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientName = table.Column<string>(type: "text", nullable: true),
                    CountProd = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "Id", "Address_Store", "Email_Store", "Name_Store", "Phone_Store" },
                values: new object[] { 1, "Москва", "prod@mail.ru", "ПродуктЗБС", "984" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Name_Department", "ProductStore_Id" },
                values: new object[,]
                {
                    { 1, "Мясной", 1 },
                    { 2, "Рыбный", 1 },
                    { 3, "Молочный", 1 },
                    { 4, "Хлебный", 1 }
                });

            migrationBuilder.InsertData(
                table: "Bread",
                columns: new[] { "Id", "Count", "Department_Id", "Name_Prod", "Price", "ProductStore_Id" },
                values: new object[,]
                {
                    { 1, 1, 4, "Ржаной", 40m, 1 },
                    { 2, 1, 4, "Белый", 50m, 1 },
                    { 3, 1, 4, "Бездрожжевой", 80m, 1 },
                    { 4, 1, 4, "Белковый", 90m, 1 },
                    { 5, 1, 4, "Лаваш", 40m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Fish",
                columns: new[] { "Id", "Department_Id", "Name_Prod", "Price", "ProductStore_Id", "Weight" },
                values: new object[,]
                {
                    { 1, 2, "Осетр", 300m, 1, 1.0 },
                    { 2, 2, "Карась", 200m, 1, 1.0 },
                    { 3, 2, "Щука", 150m, 1, 1.0 },
                    { 4, 2, "Килька", 100m, 1, 1.0 },
                    { 5, 2, "Сельдь", 400m, 1, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Meat",
                columns: new[] { "Id", "Department_Id", "Name_Prod", "Price", "ProductStore_Id", "Weight" },
                values: new object[,]
                {
                    { 1, 1, "Говядина", 800m, 1, 1.0 },
                    { 2, 1, "Курица", 500m, 1, 1.0 },
                    { 3, 1, "Индейка", 400m, 1, 1.0 },
                    { 4, 1, "Свинина", 900m, 1, 1.0 },
                    { 5, 1, "Утка", 300m, 1, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Milk",
                columns: new[] { "Id", "Count", "Department_Id", "Name_Prod", "Price", "ProductStore_Id" },
                values: new object[,]
                {
                    { 1, 1, 3, "Коровье", 80m, 1 },
                    { 2, 1, 3, "Козье", 90m, 1 },
                    { 3, 1, 3, "Оленье", 150m, 1 },
                    { 4, 1, 3, "Кобылье", 150m, 1 },
                    { 5, 1, 3, "Кролика", 100m, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Store_Email_Store",
                table: "Store",
                column: "Email_Store",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Store_Phone_Store",
                table: "Store",
                column: "Phone_Store",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Milk_Department_Id",
                table: "Milk",
                column: "Department_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Milk_ProductStore_Id",
                table: "Milk",
                column: "ProductStore_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Meat_Department_Id",
                table: "Meat",
                column: "Department_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Meat_ProductStore_Id",
                table: "Meat",
                column: "ProductStore_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_Department_Id",
                table: "Managers",
                column: "Department_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_Email",
                table: "Managers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Managers_Phone",
                table: "Managers",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Managers_ProductStore_Id",
                table: "Managers",
                column: "ProductStore_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Fish_Department_Id",
                table: "Fish",
                column: "Department_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Fish_ProductStore_Id",
                table: "Fish",
                column: "ProductStore_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Department_ProductStore_Id",
                table: "Department",
                column: "ProductStore_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bread_Department_Id",
                table: "Bread",
                column: "Department_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bread_ProductStore_Id",
                table: "Bread",
                column: "ProductStore_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bread_Department_Department_Id",
                table: "Bread",
                column: "Department_Id",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bread_Store_ProductStore_Id",
                table: "Bread",
                column: "ProductStore_Id",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Store_ProductStore_Id",
                table: "Department",
                column: "ProductStore_Id",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fish_Department_Department_Id",
                table: "Fish",
                column: "Department_Id",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fish_Store_ProductStore_Id",
                table: "Fish",
                column: "ProductStore_Id",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Managers_Department_Department_Id",
                table: "Managers",
                column: "Department_Id",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Managers_Store_ProductStore_Id",
                table: "Managers",
                column: "ProductStore_Id",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meat_Department_Department_Id",
                table: "Meat",
                column: "Department_Id",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meat_Store_ProductStore_Id",
                table: "Meat",
                column: "ProductStore_Id",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Milk_Department_Department_Id",
                table: "Milk",
                column: "Department_Id",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Milk_Store_ProductStore_Id",
                table: "Milk",
                column: "ProductStore_Id",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bread_Department_Department_Id",
                table: "Bread");

            migrationBuilder.DropForeignKey(
                name: "FK_Bread_Store_ProductStore_Id",
                table: "Bread");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_Store_ProductStore_Id",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Fish_Department_Department_Id",
                table: "Fish");

            migrationBuilder.DropForeignKey(
                name: "FK_Fish_Store_ProductStore_Id",
                table: "Fish");

            migrationBuilder.DropForeignKey(
                name: "FK_Managers_Department_Department_Id",
                table: "Managers");

            migrationBuilder.DropForeignKey(
                name: "FK_Managers_Store_ProductStore_Id",
                table: "Managers");

            migrationBuilder.DropForeignKey(
                name: "FK_Meat_Department_Department_Id",
                table: "Meat");

            migrationBuilder.DropForeignKey(
                name: "FK_Meat_Store_ProductStore_Id",
                table: "Meat");

            migrationBuilder.DropForeignKey(
                name: "FK_Milk_Department_Department_Id",
                table: "Milk");

            migrationBuilder.DropForeignKey(
                name: "FK_Milk_Store_ProductStore_Id",
                table: "Milk");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Store_Email_Store",
                table: "Store");

            migrationBuilder.DropIndex(
                name: "IX_Store_Phone_Store",
                table: "Store");

            migrationBuilder.DropIndex(
                name: "IX_Milk_Department_Id",
                table: "Milk");

            migrationBuilder.DropIndex(
                name: "IX_Milk_ProductStore_Id",
                table: "Milk");

            migrationBuilder.DropIndex(
                name: "IX_Meat_Department_Id",
                table: "Meat");

            migrationBuilder.DropIndex(
                name: "IX_Meat_ProductStore_Id",
                table: "Meat");

            migrationBuilder.DropIndex(
                name: "IX_Managers_Department_Id",
                table: "Managers");

            migrationBuilder.DropIndex(
                name: "IX_Managers_Email",
                table: "Managers");

            migrationBuilder.DropIndex(
                name: "IX_Managers_Phone",
                table: "Managers");

            migrationBuilder.DropIndex(
                name: "IX_Managers_ProductStore_Id",
                table: "Managers");

            migrationBuilder.DropIndex(
                name: "IX_Fish_Department_Id",
                table: "Fish");

            migrationBuilder.DropIndex(
                name: "IX_Fish_ProductStore_Id",
                table: "Fish");

            migrationBuilder.DropIndex(
                name: "IX_Department_ProductStore_Id",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Bread_Department_Id",
                table: "Bread");

            migrationBuilder.DropIndex(
                name: "IX_Bread_ProductStore_Id",
                table: "Bread");

            migrationBuilder.DeleteData(
                table: "Bread",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bread",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bread",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bread",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bread",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Meat",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meat",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Meat",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Meat",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Meat",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Milk",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Milk",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Milk",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Milk",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Milk",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "ProductStore_Id",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Meat",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Fish",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "Phone_Store",
                table: "Store",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name_Store",
                table: "Store",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email_Store",
                table: "Store",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address_Store",
                table: "Store",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductStore_Id",
                table: "Milk",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name_Prod",
                table: "Milk",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Department_Id",
                table: "Milk",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductStore_Id",
                table: "Meat",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name_Prod",
                table: "Meat",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Department_Id",
                table: "Meat",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductStore_Id",
                table: "Managers",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Managers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Managers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Managers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Managers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Department_Id",
                table: "Managers",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Managers",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true,
                oldDefaultValue: 18);

            migrationBuilder.AlterColumn<int>(
                name: "ProductStore_Id",
                table: "Fish",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name_Prod",
                table: "Fish",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Department_Id",
                table: "Fish",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name_Department",
                table: "Department",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Product_Store_Id",
                table: "Department",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ProductStore_Id",
                table: "Bread",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name_Prod",
                table: "Bread",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Department_Id",
                table: "Bread",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);
        }
    }
}
