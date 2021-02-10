using BankAccounts.Data.Context;
using BankAccounts.Domain.Entities;
using BankAccounts.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;

namespace BankAccounts.Data.Repositories
{
    public class BankAccountRepository : Repository<BankAccount>, IBankAccountRepository
    {
        public BankAccountRepository(DataContext context) : base(context)
        { }

        public IEnumerable<BankAccount> GetAll(string search, string searchField, string orderBy, string searchOrder, int pageNumber, int pageSize)
        {
            var list = Query(b => !b.DeletedAt.HasValue);

            if (!string.IsNullOrEmpty(orderBy))
            {
                if (!string.IsNullOrEmpty(searchOrder))
                {
                    orderBy = $"{orderBy} {searchOrder}";
                }
                list = list.OrderBy(orderBy);
            }

            if (!string.IsNullOrEmpty(search))
            {
                list = list.Where($"{searchField}.Contains(\"{search}\")");
            }



            return list.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }

        public BankAccount GetById(Guid id)
        {
            var account = Find(b => b.Id == id);
            if (!account.DeletedAt.HasValue)
            {
                return account;
            } else
            {
                throw new Exception("account not found.");
            }
        }

        public bool DeleteBankAccount(Guid id)
        {
            return Delete(b => b.Id == id && !b.DeletedAt.HasValue);
        }

        public bool ToggleBankAccountStatus(Guid id)
        {
            var account = Find(b => b.Id == id);
            if (!account.DeletedAt.HasValue)
            {
                account.Active = !account.Active;
                return Update(account);
            }
            else
            {
                throw new Exception("account not found.");
            }
            
        }

        public bool SaveBankAccount(BankAccount account)
        {
            if (!account.DeletedAt.HasValue)
            {
                if (account.Id == Guid.Empty)
                    return Create(account) != null;

                return Update(account);
            } else
            {
                throw new Exception("account not found.");
            }



        }
    }
}
