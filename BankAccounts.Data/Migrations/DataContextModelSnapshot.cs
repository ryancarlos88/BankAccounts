﻿// <auto-generated />
using System;
using BankAccounts.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BankAccounts.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BankAccounts.Domain.Entities.BankAccount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Agency")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("BankCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BankAccounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b826bf43-635a-40f7-b305-dfaf010be0da"),
                            Account = "11111-1",
                            Active = false,
                            Agency = "1111",
                            BankCode = "267",
                            CreatedAt = new DateTime(2021, 2, 9, 19, 40, 52, 256, DateTimeKind.Local).AddTicks(6484),
                            Document = "111.111.111-11",
                            Name = "Seed de dados 1"
                        },
                        new
                        {
                            Id = new Guid("b2e2cdc2-2db3-4862-80e1-07454505bbc0"),
                            Account = "22222-2",
                            Active = false,
                            Agency = "2222",
                            BankCode = "267",
                            CreatedAt = new DateTime(2021, 2, 9, 19, 40, 52, 257, DateTimeKind.Local).AddTicks(6111),
                            Document = "222.222.222-22",
                            Name = "Seed de dados 2"
                        },
                        new
                        {
                            Id = new Guid("36ff9a85-1148-4718-b0e2-6243583f0665"),
                            Account = "33333-3",
                            Active = true,
                            Agency = "3333",
                            BankCode = "267",
                            CreatedAt = new DateTime(2021, 2, 9, 19, 40, 52, 257, DateTimeKind.Local).AddTicks(6141),
                            Document = "333.333.333-33",
                            Name = "Seed de dados 3"
                        },
                        new
                        {
                            Id = new Guid("6ff5e90d-e1a5-43c8-a23a-6f8ee61ee3c9"),
                            Account = "44444-4",
                            Active = true,
                            Agency = "4444",
                            BankCode = "267",
                            CreatedAt = new DateTime(2021, 2, 9, 19, 40, 52, 257, DateTimeKind.Local).AddTicks(6144),
                            Document = "444.444.444-44",
                            Name = "Seed de dados 4"
                        },
                        new
                        {
                            Id = new Guid("e06d5691-b4cb-4c6a-9abc-db933679a100"),
                            Account = "55555-5",
                            Active = false,
                            Agency = "5555",
                            BankCode = "267",
                            CreatedAt = new DateTime(2021, 2, 9, 19, 40, 52, 257, DateTimeKind.Local).AddTicks(6146),
                            Document = "555.555.555-55",
                            Name = "Seed de dados 5"
                        },
                        new
                        {
                            Id = new Guid("306f75b8-ac2d-422e-8521-66d47dd0e228"),
                            Account = "66666-6",
                            Active = true,
                            Agency = "6666",
                            BankCode = "267",
                            CreatedAt = new DateTime(2021, 2, 9, 19, 40, 52, 257, DateTimeKind.Local).AddTicks(6149),
                            Document = "666.666.666-66",
                            Name = "Seed de dados 6"
                        },
                        new
                        {
                            Id = new Guid("d9e9870e-2bcc-4f18-a9fc-5b8c353e3cc5"),
                            Account = "77777-7",
                            Active = true,
                            Agency = "7777",
                            BankCode = "267",
                            CreatedAt = new DateTime(2021, 2, 9, 19, 40, 52, 257, DateTimeKind.Local).AddTicks(6151),
                            Document = "777.777.777-77",
                            Name = "Seed de dados 7"
                        },
                        new
                        {
                            Id = new Guid("86f4db68-c34d-49dc-9493-1c73238fb391"),
                            Account = "88888-8",
                            Active = false,
                            Agency = "8888",
                            BankCode = "267",
                            CreatedAt = new DateTime(2021, 2, 9, 19, 40, 52, 257, DateTimeKind.Local).AddTicks(6153),
                            Document = "888.888.888-88",
                            Name = "Seed de dados 3"
                        },
                        new
                        {
                            Id = new Guid("b389e1ee-afc5-4424-8d06-9e527f144812"),
                            Account = "99999-9",
                            Active = true,
                            Agency = "9999",
                            BankCode = "267",
                            CreatedAt = new DateTime(2021, 2, 9, 19, 40, 52, 257, DateTimeKind.Local).AddTicks(6155),
                            Document = "999.999.999-99",
                            Name = "Seed de dados 9"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
