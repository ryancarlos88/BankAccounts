using AutoMapper;
using BankAccounts.Application.ViewModels.BankAccount;
using BankAccounts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts.Application.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region ViewModelToDomain

            CreateMap<BankAccountFormViewModel, BankAccount>();

            #endregion

            #region DomainToViewModel

            CreateMap<BankAccount, BankAccountDetailsViewModel>()
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt.ToString("dd/MM/yyyy")))
                .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt != null ? src.DeletedAt.Value.ToString("dd/MM/yyyy") : " - "))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt != null ? src.UpdatedAt.Value.ToString("dd/MM/yyyy") : " - "))
                .ForMember(dest => dest.Active, opt => opt.MapFrom(src => src.Active ? "Sim" : "Não"));
            CreateMap<BankAccount, BankAccountFormViewModel>();
            CreateMap<BankAccount, BankAccountListViewModel>();

            #endregion
        }
    }
}
