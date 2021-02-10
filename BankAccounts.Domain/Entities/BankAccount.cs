using BankAccounts.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts.Domain.Entities
{
    public class BankAccount : BaseEntity
    {
        public string BankCode { get; set; }
        public string Account { get; set; }
        public string Agency { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
