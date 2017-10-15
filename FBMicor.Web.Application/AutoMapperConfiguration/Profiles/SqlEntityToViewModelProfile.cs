using FBMicro.Web.Application.ViewModel;
using FBMicro.Data.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBMicro.Web.Application.AutoMapperConfiguration.Profiles
{
    public class SqlEntityToViewModelProfile : AutoMapper.Profile
    {
        public override string ProfileName
        {
            get { return "SqlEntityToViewModelProfile"; }
        }

        public SqlEntityToViewModelProfile()
        {
            CreateMap<BankMaster, BankDetailsVM>()
               .ForMember(model => model.BankID, map => map.MapFrom(m => m.Id))
               .ForMember(model => model.BankName, map => map.MapFrom(m => m.Name))
               .ForMember(model => model.BankLogo, map => map.MapFrom(m => m.BankLogoPath))
               .ForMember(model => model.BankDescription, map => map.MapFrom(m => m.Description))
               .ForMember(model => model.offerPercentage, map => map.MapFrom(m => Convert.ToString(m.OfferPercentage)))
               .ForMember(model => model.Selected, map => map.Ignore());

            CreateMap<BankLoanDetail, BankLoanDetailsVM>()
               .ForMember(model => model.DocumentCharges, map => map.MapFrom(m => m.DocumentCharges))
               .ForMember(model => model.bankDetails, map => map.MapFrom(m => m.BankMaster))
               .ForMember(model => model.ForeClosureCharges, map => map.MapFrom(m => m.ForeClosureCharges))
               .ForMember(model => model.Id, map => map.MapFrom(m => m.Id))
               .ForMember(model => model.MODCharges, map => map.MapFrom(m => m.MODCharges))
               .ForMember(model => model.OffersIfAny, map => map.MapFrom(m => m.OffersIfAny))
               .ForMember(model => model.PrePaymentCharges, map => map.MapFrom(m => m.PrePaymentCharges))
               .ForMember(model => model.ProcessingFeeAbove30Lks, map => map.MapFrom(m => m.ProcessingFeeAbove30Lk))
               .ForMember(model => model.ProcessingFeeBelow30Lks, map => map.MapFrom(m => m.ProcessingFeeBelow30Lk))
               .ForMember(model => model.ROIAbove30Lks, map => map.MapFrom(m => m.ROIAbove30Lk))
               .ForMember(model => model.ROIBelow30Lks, map => map.MapFrom(m => m.ROIBelow30Lk));
        }
    }
}