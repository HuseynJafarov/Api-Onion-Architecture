using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class CreateNewBookTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 16, 23, 42, 41, 979, DateTimeKind.Utc).AddTicks(2920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 16, 23, 10, 14, 984, DateTimeKind.Utc).AddTicks(4801));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Book",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 16, 23, 42, 41, 980, DateTimeKind.Utc).AddTicks(1331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 16, 23, 10, 14, 985, DateTimeKind.Utc).AddTicks(5931));

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Book",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 16, 23, 10, 14, 984, DateTimeKind.Utc).AddTicks(4801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 16, 23, 42, 41, 979, DateTimeKind.Utc).AddTicks(2920));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Book",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 16, 23, 10, 14, 985, DateTimeKind.Utc).AddTicks(5931),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 16, 23, 42, 41, 980, DateTimeKind.Utc).AddTicks(1331));

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Book",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
