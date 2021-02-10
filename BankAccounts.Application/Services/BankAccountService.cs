using AutoMapper;
using BankAccounts.Application.Interfaces;
using BankAccounts.Application.ViewModels.BankAccount;
using BankAccounts.Domain.Entities;
using BankAccounts.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts.Application.Services
{
    public class BankAccountService : IBankAccountService
    {
        private readonly IBankAccountRepository bankAccountRepository;
        private readonly IMapper mapper;
        public BankAccountService(IBankAccountRepository bankAccountRepository, IMapper mapper)
        {
            this.bankAccountRepository = bankAccountRepository;
            this.mapper = mapper;
        }
        public bool DeleteBankAccount(Guid id)
        {
            return bankAccountRepository.DeleteBankAccount(id);
        }        

        public BankAccountDetailsViewModel GetBankAccount(Guid id)
        {
            return mapper.Map<BankAccountDetailsViewModel>(bankAccountRepository.GetById(id));
        }

        public List<BankAccountListViewModel> GetBankAccountsList(string search, string searchField, string orderBy, string sortOrder, int pageNumber, int pageSize)
        {
            return mapper.Map<List<BankAccountListViewModel>>(bankAccountRepository.GetAll(search, searchField, orderBy, sortOrder, pageNumber, pageSize));
        }

        public bool SaveBankAccount(BankAccountFormViewModel model)
        {
            return bankAccountRepository.SaveBankAccount(mapper.Map<BankAccount>(model));
        }

        public bool ToggleBankAccountStatus(Guid id)
        {
            return bankAccountRepository.ToggleBankAccountStatus(id);
        }
    }
}
