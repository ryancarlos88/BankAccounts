using BankAccounts.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts.Data.Mappings
{
    class BankAccountMap : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.Property(b => b.Id).IsRequired();
            builder.Property(b => b.Account).HasMaxLength(10).IsRequired();
            builder.Property(b => b.Active).IsRequired();
            builder.Property(b => b.Agency).HasMaxLength(6).IsRequired();
            builder.Property(b => b.BankCode).HasMaxLength(10).IsRequired();
            builder.Property(b => b.Document).HasMaxLength(20).IsRequired();
            builder.Property(b => b.Name).HasMaxLength(100).IsRequired();
            builder.Property(b => b.CreatedAt).IsRequired();
        }
    }
}
