using FBMicro.Web.Application.AutoMapperConfiguration.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBMicro.Web.Application.AutoMapperConfiguration
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            AutoMapper.Mapper.Initialize(x =>
            {
                x.AddProfile<ViewModelToSqlEntityProfile>();
                x.AddProfile<SqlEntityToViewModelProfile>();
            });
        }
    }
}