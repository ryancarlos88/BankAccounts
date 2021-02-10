using BankAccounts.Application.ViewModels.BankAccount;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts.Application.Interfaces
{
    public interface IBankAccountService
    {
        bool SaveBankAccount(BankAccountFormViewModel model);
        List<BankAccountListViewModel> GetBankAccountsList(string search, string searchField, string orderBy, string sortOrder, int pageNumber, int pageSize);
        BankAccountDetailsViewModel GetBankAccount(Guid id);
        bool DeleteBankAccount(Guid id);        
        bool ToggleBankAccountStatus(Guid id);
    }
}
