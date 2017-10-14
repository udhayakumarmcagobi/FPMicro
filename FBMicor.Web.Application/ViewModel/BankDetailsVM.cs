using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBMicor.Web.Application.ViewModel
{
    public class BankDetailsVM
    {
        public string BankID { get; set; }
        public string BankName { get; set; }
        public string offerPercentage { get; set; }
        public bool Selected { get; set; }
    }
}