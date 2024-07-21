using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedSalesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CommissionData",
                columns: new[] { "Id", "Brand", "ClassACommission", "ClassBCommission", "ClassCCommission", "FixedCommission", "Threshold" },
                values: new object[,]
                {
                    { 1, "Audi", 0.080000000000000002, 0.059999999999999998, 0.040000000000000001, 800, 25000 },
                    { 2, "Jaguar", 0.059999999999999998, 0.050000000000000003, 0.029999999999999999, 750, 35000 },
                    { 3, "Land Rover", 0.070000000000000007, 0.050000000000000003, 0.040000000000000001, 850, 30000 },
                    { 4, "Renault", 0.050000000000000003, 0.029999999999999999, 0.02, 400, 20000 }
                });

            migrationBuilder.InsertData(
                table: "PreviousYearSales",
                columns: new[] { "Id", "LastYearSales", "Salesman" },
                values: new object[,]
                {
                    { 1, 490000.0, "Salesman 1" },
                    { 2, 1000000.0, "Salesman 2" },
                    { 3, 650000.0, "Salesman 3" }
                });

            migrationBuilder.InsertData(
                table: "SalesData",
                columns: new[] { "Id", "Brand", "Class", "ModelPrice", "NumberOfCarsSold", "Salesman" },
                values: new object[,]
                {
                    { 1, "Audi", "A", 30000.0, 1, "Salesman 1" },
                    { 2, "Jaguar", "A", 40000.0, 3, "Salesman 1" },
                    { 3, "Land Rover", "A", 35000.0, 0, "Salesman 1" },
                    { 4, "Renault", "A", 25000.0, 6, "Salesman 1" },
                    { 5, "Audi", "B", 28000.0, 2, "Salesman 1" },
                    { 6, "Jaguar", "B", 36000.0, 4, "Salesman 1" },
                    { 7, "Land Rover", "B", 32000.0, 2, "Salesman 1" },
                    { 8, "Renault", "B", 22000.0, 2, "Salesman 1" },
                    { 9, "Audi", "C", 26000.0, 3, "Salesman 1" },
                    { 10, "Jaguar", "C", 34000.0, 6, "Salesman 1" },
                    { 11, "Land Rover", "C", 31000.0, 1, "Salesman 1" },
                    { 12, "Renault", "C", 21000.0, 1, "Salesman 1" },
                    { 13, "Audi", "A", 30000.0, 0, "Salesman 2" },
                    { 14, "Jaguar", "A", 40000.0, 5, "Salesman 2" },
                    { 15, "Land Rover", "A", 35000.0, 5, "Salesman 2" },
                    { 16, "Renault", "A", 25000.0, 3, "Salesman 2" },
                    { 17, "Audi", "B", 28000.0, 0, "Salesman 2" },
                    { 18, "Jaguar", "B", 36000.0, 4, "Salesman 2" },
                    { 19, "Land Rover", "B", 32000.0, 2, "Salesman 2" },
                    { 20, "Renault", "B", 22000.0, 2, "Salesman 2" },
                    { 21, "Audi", "C", 26000.0, 0, "Salesman 2" },
                    { 22, "Jaguar", "C", 34000.0, 2, "Salesman 2" },
                    { 23, "Land Rover", "C", 31000.0, 1, "Salesman 2" },
                    { 24, "Renault", "C", 21000.0, 1, "Salesman 2" },
                    { 25, "Audi", "A", 30000.0, 4, "Salesman 3" },
                    { 26, "Jaguar", "A", 40000.0, 2, "Salesman 3" },
                    { 27, "Land Rover", "A", 35000.0, 1, "Salesman 3" },
                    { 28, "Renault", "A", 25000.0, 6, "Salesman 3" },
                    { 29, "Audi", "B", 28000.0, 2, "Salesman 3" },
                    { 30, "Jaguar", "B", 36000.0, 7, "Salesman 3" },
                    { 31, "Land Rover", "B", 32000.0, 2, "Salesman 3" },
                    { 32, "Renault", "B", 22000.0, 3, "Salesman 3" },
                    { 33, "Audi", "C", 26000.0, 0, "Salesman 3" },
                    { 34, "Jaguar", "C", 34000.0, 1, "Salesman 3" },
                    { 35, "Land Rover", "C", 31000.0, 3, "Salesman 3" },
                    { 36, "Renault", "C", 21000.0, 1, "Salesman 3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CommissionData",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CommissionData",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CommissionData",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CommissionData",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PreviousYearSales",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PreviousYearSales",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PreviousYearSales",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "Id",
                keyValue: 36);
        }
    }
}
