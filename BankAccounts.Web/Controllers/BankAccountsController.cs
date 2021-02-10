using BankAccounts.Application.Interfaces;
using BankAccounts.Application.ViewModels.BankAccount;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccounts.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountsController : Controller
    {

        private readonly IBankAccountService bankAccountService;
        public BankAccountsController(IBankAccountService bankAccountService)
        {
            this.bankAccountService = bankAccountService;
        }
        [HttpGet]
        public IActionResult Index(string search, string searchField, string orderBy, string sortOrder, int pageNumber = 1, int pageSize = 10) 
        {
            return Ok(bankAccountService.GetBankAccountsList(search, searchField, orderBy, sortOrder, pageNumber, pageSize));
        }
        
        [HttpGet("{id}")]        
        public IActionResult Details(Guid id)
        {
            return Ok(bankAccountService.GetBankAccount(id));
        }

        [HttpPatch("{id}")]        
        public IActionResult ToggleStatus(Guid id)
        {
            return Ok(bankAccountService.ToggleBankAccountStatus(id));
        }      

        [HttpPost]
        public IActionResult CreateBankAccount(BankAccountFormViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(bankAccountService.SaveBankAccount(model));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBankAccount(Guid id)
        {
            return Ok(bankAccountService.DeleteBankAccount(id));
        }
    }
}
