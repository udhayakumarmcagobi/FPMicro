using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBMicro.Web.Application.ViewModel
{
    public class BankLoanDetailsVM
    {
        public BankLoanDetailsVM()
        {
            bankDetails = new ViewModel.BankDetailsVM();
        }

        public int Id { get; set; }
        public BankDetailsVM bankDetails { get; set; }
        public decimal? ROIBelow30Lks { get; set; }
        public decimal? ROIAbove30Lks { get; set; }
        public decimal? ProcessingFeeBelow30Lks { get; set; }
        public decimal? ProcessingFeeAbove30Lks { get; set; }
        public decimal? MODCharges { get; set; }
        public decimal DocumentCharges { get; set; }
        public decimal? ForeClosureCharges { get; set; }
        public decimal? PrePaymentCharges { get; set; }
        public string OffersIfAny { get; set; }
    }
}