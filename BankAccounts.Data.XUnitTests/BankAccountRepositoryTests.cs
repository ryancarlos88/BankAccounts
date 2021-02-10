using System;
using Xunit;
using BankAccounts.Data.Repositories;
using BankAccounts.Data.Context;
using Moq;
using Microsoft.EntityFrameworkCore;
using BankAccounts.Domain.Entities;

namespace BankAccounts.Data.XUnitTests
{
    public class BankAccountRepositoryTests
    {
        [Fact]
        public void Find_Should_Return_Bank_Account()
        {
            //Arrange
            var dataContextMock = new Mock<DataContext>();
            var dbSetMock = new Mock<DbSet<BankAccount>>();
            dbSetMock.Setup(b => b.Find(It.IsAny<Guid>())).Returns(new BankAccount());
            dataContextMock.Setup(b => b.Set<BankAccount>()).Returns(dbSetMock.Object);

            //Act
            var bankAccountRepository = new BankAccountRepository(dataContextMock.Object);
            var bankAccount = bankAccountRepository.Find(new Guid());

            //Assert
            Assert.NotNull(bankAccount);
            Assert.IsAssignableFrom<BankAccount>(bankAccount);
        }
    }
}
