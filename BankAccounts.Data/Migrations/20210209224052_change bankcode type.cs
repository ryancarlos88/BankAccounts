using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankAccounts.Data.Migrations
{
    public partial class changebankcodetype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BankCode",
                table: "BankAccounts",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("306f75b8-ac2d-422e-8521-66d47dd0e228"),
                columns: new[] { "BankCode", "CreatedAt" },
                values: new object[] { "267", new DateTime(2021, 2, 9, 19, 40, 52, 257, DateTimeKind.Local).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("36ff9a85-1148-4718-b0e2-6243583f0665"),
                columns: new[] { "BankCode", "CreatedAt" },
                values: new object[] { "267", new DateTime(2021, 2, 9, 19, 40, 52, 257, DateTimeKind.Local).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("6ff5e90d-e1a5-43c8-a23a-6f8ee61ee3c9"),
                columns: new[] { "BankCode", "CreatedAt" },
                values: new object[] { "267", new DateTime(2021, 2, 9, 19, 40, 52, 257, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("86f4db68-c34d-49dc-9493-1c73238fb391"),
                columns: new[] { "BankCode", "CreatedAt" },
                values: new object[] { "267", new DateTime(2021, 2, 9, 19, 40, 52, 257, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("b2e2cdc2-2db3-4862-80e1-07454505bbc0"),
                columns: new[] { "BankCode", "CreatedAt" },
                values: new object[] { "267", new DateTime(2021, 2, 9, 19, 40, 52, 257, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("b389e1ee-afc5-4424-8d06-9e527f144812"),
                columns: new[] { "BankCode", "CreatedAt" },
                values: new object[] { "267", new DateTime(2021, 2, 9, 19, 40, 52, 257, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("b826bf43-635a-40f7-b305-dfaf010be0da"),
                columns: new[] { "BankCode", "CreatedAt" },
                values: new object[] { "267", new DateTime(2021, 2, 9, 19, 40, 52, 256, DateTimeKind.Local).AddTicks(6484) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("d9e9870e-2bcc-4f18-a9fc-5b8c353e3cc5"),
                columns: new[] { "BankCode", "CreatedAt" },
                values: new object[] { "267", new DateTime(2021, 2, 9, 19, 40, 52, 257, DateTimeKind.Local).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("e06d5691-b4cb-4c6a-9abc-db933679a100"),
                columns: new[] { "BankCode", "CreatedAt" },
                values: new object[] { "267", new DateTime(2021, 2, 9, 19, 40, 52, 257, DateTimeKind.Local).AddTicks(6146) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BankCode",
                table: "BankAccounts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("306f75b8-ac2d-422e-8521-66d47dd0e228"),
                columns: new[] { "BankCode", "CreatedAt" },
                values: new object[] { 267, new DateTime(2021, 2, 9, 17, 8, 35, 770, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("36ff9a85-1148-4718-b0e2-6243583f0665"),
                columns: new[] { "BankCode", "CreatedAt" },
                values: new object[] { 267, new DateTime(2021, 2, 9, 17, 8, 35, 770, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("6ff5e90d-e1a5-43c8-a23a-6f8ee61ee3c9"),
                columns: new[] { "BankCode", "CreatedAt" },
                values: new object[] { 267, new DateTime(2021, 2, 9, 17, 8, 35, 770, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("86f4db68-c34d-49dc-9493-1c73238fb391"),
                columns: new[] { "BankCode", "CreatedAt" },
                values: new object[] { 267, new DateTime(2021, 2, 9, 17, 8, 35, 770, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("b2e2cdc2-2db3-4862-80e1-07454505bbc0"),
                columns: new[] { "BankCode", "CreatedAt" },
                values: new object[] { 267, new DateTime(2021, 2, 9, 17, 8, 35, 770, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("b389e1ee-afc5-4424-8d06-9e527f144812"),
                columns: new[] { "BankCode", "CreatedAt" },
                values: new object[] { 267, new DateTime(2021, 2, 9, 17, 8, 35, 770, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("b826bf43-635a-40f7-b305-dfaf010be0da"),
                columns: new[] { "BankCode", "CreatedAt" },
                values: new object[] { 267, new DateTime(2021, 2, 9, 17, 8, 35, 769, DateTimeKind.Local).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("d9e9870e-2bcc-4f18-a9fc-5b8c353e3cc5"),
                columns: new[] { "BankCode", "CreatedAt" },
                values: new object[] { 267, new DateTime(2021, 2, 9, 17, 8, 35, 770, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("e06d5691-b4cb-4c6a-9abc-db933679a100"),
                columns: new[] { "BankCode", "CreatedAt" },
                values: new object[] { 267, new DateTime(2021, 2, 9, 17, 8, 35, 770, DateTimeKind.Local).AddTicks(2834) });
        }
    }
}
