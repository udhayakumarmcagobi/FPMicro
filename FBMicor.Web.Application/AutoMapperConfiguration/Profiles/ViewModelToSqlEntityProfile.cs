using FBMicor.Web.Application.ViewModel;
using FBMicro.Data.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBMicor.Web.Application.AutoMapperConfiguration.Profiles
{
    public class ViewModelToSqlEntityProfile : AutoMapper.Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToSqlEntityProfile"; }
        }

        public ViewModelToSqlEntityProfile()
        {
            CreateMap<HomeLoanVM, UserDetail>()
               .ForMember(model => model.ContactNo, map => map.MapFrom(m => m.customer.CustomerPhone))
               .ForMember(model => model.Name, map => map.MapFrom(m => m.customer.CustomerName))
               .ForMember(model => model.Id, map => map.MapFrom(m => m.customer.CustomerID));

            CreateMap<HomeLoanVM, UserHomeLoanDetail>()
               .ForMember(model => model.BankId, map => map.MapFrom(m => m.selectedBankID))
               .ForMember(model => model.UserId, map => map.MapFrom(m => m.customer.CustomerID))
               .ForMember(model => model.LoanAmount, map => map.MapFrom(m => m.LoanAmount));

            CreateMap<BalanceTransferVM, UserBalanceTransferDetail>()
               .ForMember(model => model.BankId, map => map.MapFrom(m => m.selectedBankID))
               .ForMember(model => model.UserId, map => map.MapFrom(m => m.customer.CustomerID))
               .ForMember(model => model.isTopUpNeeded, map => map.MapFrom(m => m.IsTopUp))
               .ForMember(model => model.TopUpAmount, map => map.MapFrom(m => m.TopUpAmount))
               .ForMember(model => model.LoanAmount, map => map.MapFrom(m => m.LoanAmount));

            CreateMap<CustomerVM, UserDetail>()
               .ForMember(model => model.ContactNo, map => map.MapFrom(m => m.CustomerPhone))
               .ForMember(model => model.Name, map => map.MapFrom(m => m.CustomerName))
               .ForMember(model => model.Id, map => map.MapFrom(m => m.CustomerID));            
        }
    }
}