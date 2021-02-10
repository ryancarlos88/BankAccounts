using BankAccounts.Domain.Entities;
using BankAccounts.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder ApplyGlobalConfigurations(this ModelBuilder builder)
        {
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    switch (property.Name)
                    {
                        case nameof(BaseEntity.Id):
                            property.IsKey();
                            break;
                        case nameof(BaseEntity.UpdatedAt):
                            property.IsNullable = true;
                            break;
                        case nameof(BaseEntity.DeletedAt):
                            property.IsNullable = true;
                            break;
                        case nameof(BaseEntity.CreatedAt):
                            property.IsNullable = false;
                            property.SetDefaultValueSql("GETDATE()");
                            break;
                    }
                }
            }
            return builder;
        }
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<BankAccount>().
                HasData(
                    new BankAccount
                    {
                        Id = Guid.Parse("b826bf43-635a-40f7-b305-dfaf010be0da"),
                        Agency= "1111",
                        Active = false,
                        Account = "11111-1",
                        BankCode = "267",
                        Document = "111.111.111-11",
                        Name = "Seed de dados 1",
                        CreatedAt = DateTime.Now

                    },
                    new BankAccount
                    {
                        Id = Guid.Parse("b2e2cdc2-2db3-4862-80e1-07454505bbc0"),
                        Agency= "2222",
                        Active = false,
                        Account = "22222-2",
                        BankCode = "267",
                        Document = "222.222.222-22",
                        Name = "Seed de dados 2",
                        CreatedAt = DateTime.Now


                    },
                    new BankAccount
                    {
                        Id = Guid.Parse("36ff9a85-1148-4718-b0e2-6243583f0665"),
                        Agency= "3333",
                        Active = true,
                        Account = "33333-3",
                        BankCode = "267",
                        Document = "333.333.333-33",
                        Name = "Seed de dados 3",
                        CreatedAt = DateTime.Now


                    },
                    new BankAccount
                    {
                        Id = Guid.Parse("6ff5e90d-e1a5-43c8-a23a-6f8ee61ee3c9"),
                        Agency= "4444",
                        Active = true,
                        Account = "44444-4",
                        BankCode = "267",
                        Document = "444.444.444-44",
                        Name = "Seed de dados 4",
                        CreatedAt = DateTime.Now


                    },
                    new BankAccount
                    {
                        Id = Guid.Parse("e06d5691-b4cb-4c6a-9abc-db933679a100"),
                        Agency= "5555",
                        Active = false,
                        Account = "55555-5",
                        BankCode = "267",
                        Document = "555.555.555-55",
                        Name = "Seed de dados 5",
                        CreatedAt = DateTime.Now


                    },
                    new BankAccount
                    {
                        Id = Guid.Parse("306f75b8-ac2d-422e-8521-66d47dd0e228"),
                        Agency= "6666",
                        Active = true,
                        Account = "66666-6",
                        BankCode = "267",
                        Document = "666.666.666-66",
                        Name = "Seed de dados 6",
                        CreatedAt = DateTime.Now


                    },
                    new BankAccount
                    {
                        Id = Guid.Parse("d9e9870e-2bcc-4f18-a9fc-5b8c353e3cc5"),
                        Agency= "7777",
                        Active = true,
                        Account = "77777-7",
                        BankCode = "267",
                        Document = "777.777.777-77",
                        Name = "Seed de dados 7",
                        CreatedAt = DateTime.Now


                    },
                    new BankAccount
                    {
                        Id = Guid.Parse("86f4db68-c34d-49dc-9493-1c73238fb391"),
                        Agency= "8888",
                        Active = false,
                        Account = "88888-8",
                        BankCode = "267",
                        Document = "888.888.888-88",
                        Name = "Seed de dados 3",
                        CreatedAt = DateTime.Now


                    },
                    new BankAccount
                    {
                        Id = Guid.Parse("b389e1ee-afc5-4424-8d06-9e527f144812"),
                        Agency= "9999",
                        Active = true,
                        Account = "99999-9",
                        BankCode = "267",
                        Document = "999.999.999-99",
                        Name = "Seed de dados 9",
                        CreatedAt = DateTime.Now


                    }
                );
            return builder;
        }
    }
}
