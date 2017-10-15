using FBMicor.Web.Application.ViewModel;
using FBMicro.Data.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBMicor.Web.Application.AutoMapperConfiguration.Profiles
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
               .ForMember(model => model.offerPercentage, map => map.MapFrom(m => Convert.ToString(m.OfferPercentage)))
               .ForMember(model => model.Selected, map => map.Ignore());
        }
    }
}