using BankAccounts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts.Domain.Interfaces
{
    public interface IBankAccountRepository
    {
        IEnumerable<BankAccount> GetAll(string search, string searchField, string orderBy, string searchOrder, int pageNumber, int pageSize);
        bool SaveBankAccount(BankAccount account);
        BankAccount GetById(Guid id);
        bool DeleteBankAccount(Guid id);
        bool ToggleBankAccountStatus(Guid id);
    }
}
