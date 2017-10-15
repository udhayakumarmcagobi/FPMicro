using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBMicor.Web.Application.ViewModel
{
    public class OfferDetailsVM
    {
        public OfferDetailsVM()
        {
            bankDetails = new List<BankDetailsVM>();
        }

        public List<BankDetailsVM> bankDetails { get; set; }
    }
}