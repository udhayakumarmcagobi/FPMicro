using FBMicor.Web.Application.AutoMapperConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBMicor.Web.Application.App_Start
{
    public class Bootstrapper
    {
        public static void RegisterComponents()
        {
            //Configure Auto Mapper
            AutoMapperConfig.Configure();
        }
    }
}