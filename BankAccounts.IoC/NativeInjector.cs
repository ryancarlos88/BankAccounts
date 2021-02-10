using BankAccounts.Application.Interfaces;
using BankAccounts.Application.Services;
using BankAccounts.Data.Repositories;
using BankAccounts.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BankAccounts.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Services
                services.AddScoped<IBankAccountService, BankAccountService>();
            #endregion

            #region Repos
                services.AddScoped<IBankAccountRepository, BankAccountRepository>();
            #endregion
        }
    }
}
