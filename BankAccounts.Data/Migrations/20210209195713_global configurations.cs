using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankAccounts.Data.Migrations
{
    public partial class globalconfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "BankAccounts",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 9, 16, 57, 13, 488, DateTimeKind.Local).AddTicks(3081),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("306f75b8-ac2d-422e-8521-66d47dd0e228"),
                column: "CreatedAt",
                value: new DateTime(2021, 2, 9, 16, 57, 13, 492, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("36ff9a85-1148-4718-b0e2-6243583f0665"),
                column: "CreatedAt",
                value: new DateTime(2021, 2, 9, 16, 57, 13, 492, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("6ff5e90d-e1a5-43c8-a23a-6f8ee61ee3c9"),
                column: "CreatedAt",
                value: new DateTime(2021, 2, 9, 16, 57, 13, 492, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("86f4db68-c34d-49dc-9493-1c73238fb391"),
                column: "CreatedAt",
                value: new DateTime(2021, 2, 9, 16, 57, 13, 492, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("b2e2cdc2-2db3-4862-80e1-07454505bbc0"),
                column: "CreatedAt",
                value: new DateTime(2021, 2, 9, 16, 57, 13, 492, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("b389e1ee-afc5-4424-8d06-9e527f144812"),
                column: "CreatedAt",
                value: new DateTime(2021, 2, 9, 16, 57, 13, 492, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("b826bf43-635a-40f7-b305-dfaf010be0da"),
                column: "CreatedAt",
                value: new DateTime(2021, 2, 9, 16, 57, 13, 492, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("d9e9870e-2bcc-4f18-a9fc-5b8c353e3cc5"),
                column: "CreatedAt",
                value: new DateTime(2021, 2, 9, 16, 57, 13, 492, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("e06d5691-b4cb-4c6a-9abc-db933679a100"),
                column: "CreatedAt",
                value: new DateTime(2021, 2, 9, 16, 57, 13, 492, DateTimeKind.Local).AddTicks(8135));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "BankAccounts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 9, 16, 57, 13, 488, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("306f75b8-ac2d-422e-8521-66d47dd0e228"),
                column: "CreatedAt",
                value: new DateTime(2021, 2, 8, 23, 9, 11, 988, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("36ff9a85-1148-4718-b0e2-6243583f0665"),
                column: "CreatedAt",
                value: new DateTime(2021, 2, 8, 23, 9, 11, 988, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("6ff5e90d-e1a5-43c8-a23a-6f8ee61ee3c9"),
                column: "CreatedAt",
                value: new DateTime(2021, 2, 8, 23, 9, 11, 988, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("86f4db68-c34d-49dc-9493-1c73238fb391"),
                column: "CreatedAt",
                value: new DateTime(2021, 2, 8, 23, 9, 11, 988, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("b2e2cdc2-2db3-4862-80e1-07454505bbc0"),
                column: "CreatedAt",
                value: new DateTime(2021, 2, 8, 23, 9, 11, 988, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("b389e1ee-afc5-4424-8d06-9e527f144812"),
                column: "CreatedAt",
                value: new DateTime(2021, 2, 8, 23, 9, 11, 988, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("b826bf43-635a-40f7-b305-dfaf010be0da"),
                column: "CreatedAt",
                value: new DateTime(2021, 2, 8, 23, 9, 11, 987, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("d9e9870e-2bcc-4f18-a9fc-5b8c353e3cc5"),
                column: "CreatedAt",
                value: new DateTime(2021, 2, 8, 23, 9, 11, 988, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("e06d5691-b4cb-4c6a-9abc-db933679a100"),
                column: "CreatedAt",
                value: new DateTime(2021, 2, 8, 23, 9, 11, 988, DateTimeKind.Local).AddTicks(4221));
        }
    }
}
