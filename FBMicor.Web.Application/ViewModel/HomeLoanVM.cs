using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBMicor.Web.Application.ViewModel
{
    public class HomeLoanVM
    {
        public string LoanAmount { get; set; }
        public List<BankDetailsVM> BankDetailsList { get; set; }
        public BankDetailsVM bankSelected { get; set; }
        public string selectedBankID { get; set; }
        public CustomerVM customer { get; set; }
    }
}