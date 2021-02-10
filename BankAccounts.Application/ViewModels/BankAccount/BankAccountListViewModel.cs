using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts.Application.ViewModels.BankAccount
{
    public class BankAccountListViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public string Agency { get; set; }
        public string Account { get; set; }
        public string BankCode { get; set; }
        public bool Active { get; set; }
    }
}
