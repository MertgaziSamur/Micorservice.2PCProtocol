using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Coordinator.Migrations
{
    /// <inheritdoc />
    public partial class seed_data_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Nodes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1a2a11a3-4647-4db1-88cc-db2d9bc0c383"), "Payment.API" },
                    { new Guid("8724e100-65ba-4d00-918f-9fb120894ba6"), "Order.API" },
                    { new Guid("a64fe254-25a1-48aa-8a77-273c61beb3fe"), "Stock.API" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("1a2a11a3-4647-4db1-88cc-db2d9bc0c383"));

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("8724e100-65ba-4d00-918f-9fb120894ba6"));

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("a64fe254-25a1-48aa-8a77-273c61beb3fe"));
        }
    }
}
