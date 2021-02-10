using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankAccounts.Data.Migrations
{
    public partial class addingnewfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    BankCode = table.Column<int>(nullable: false),
                    Account = table.Column<string>(maxLength: 10, nullable: false),
                    Agency = table.Column<string>(maxLength: 6, nullable: false),
                    Document = table.Column<string>(maxLength: 20, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "Account", "Active", "Agency", "BankCode", "CreatedAt", "DeletedAt", "Document", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("b826bf43-635a-40f7-b305-dfaf010be0da"), "11111-1", false, "1111", 267, new DateTime(2021, 2, 8, 23, 9, 11, 987, DateTimeKind.Local).AddTicks(7132), null, "111.111.111-11", "Seed de dados 1", null },
                    { new Guid("b2e2cdc2-2db3-4862-80e1-07454505bbc0"), "22222-2", false, "2222", 267, new DateTime(2021, 2, 8, 23, 9, 11, 988, DateTimeKind.Local).AddTicks(4193), null, "222.222.222-22", "Seed de dados 2", null },
                    { new Guid("36ff9a85-1148-4718-b0e2-6243583f0665"), "33333-3", true, "3333", 267, new DateTime(2021, 2, 8, 23, 9, 11, 988, DateTimeKind.Local).AddTicks(4215), null, "333.333.333-33", "Seed de dados 3", null },
                    { new Guid("6ff5e90d-e1a5-43c8-a23a-6f8ee61ee3c9"), "44444-4", true, "4444", 267, new DateTime(2021, 2, 8, 23, 9, 11, 988, DateTimeKind.Local).AddTicks(4218), null, "444.444.444-44", "Seed de dados 4", null },
                    { new Guid("e06d5691-b4cb-4c6a-9abc-db933679a100"), "55555-5", false, "5555", 267, new DateTime(2021, 2, 8, 23, 9, 11, 988, DateTimeKind.Local).AddTicks(4221), null, "555.555.555-55", "Seed de dados 5", null },
                    { new Guid("306f75b8-ac2d-422e-8521-66d47dd0e228"), "66666-6", true, "6666", 267, new DateTime(2021, 2, 8, 23, 9, 11, 988, DateTimeKind.Local).AddTicks(4223), null, "666.666.666-66", "Seed de dados 6", null },
                    { new Guid("d9e9870e-2bcc-4f18-a9fc-5b8c353e3cc5"), "77777-7", true, "7777", 267, new DateTime(2021, 2, 8, 23, 9, 11, 988, DateTimeKind.Local).AddTicks(4258), null, "777.777.777-77", "Seed de dados 7", null },
                    { new Guid("86f4db68-c34d-49dc-9493-1c73238fb391"), "88888-8", false, "8888", 267, new DateTime(2021, 2, 8, 23, 9, 11, 988, DateTimeKind.Local).AddTicks(4261), null, "888.888.888-88", "Seed de dados 3", null },
                    { new Guid("b389e1ee-afc5-4424-8d06-9e527f144812"), "99999-9", true, "9999", 267, new DateTime(2021, 2, 8, 23, 9, 11, 988, DateTimeKind.Local).AddTicks(4263), null, "999.999.999-99", "Seed de dados 9", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankAccounts");
        }
    }
}
