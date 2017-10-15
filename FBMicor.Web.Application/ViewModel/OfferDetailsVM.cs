using FBMicor.Web.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBMicro.Web.Application.ViewModel
{
    public class OfferDetailsVM
    {
        public OfferDetailsVM()
        {
            bankDetail = new BankDetailsVM();
        }

        public BankDetailsVM bankDetail { get; set; }
        public string OfferAmount { get; set; }        
        public List<VoucherDetailsVM> vouchers { get; set; }
    }
}