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
        }
    }
}