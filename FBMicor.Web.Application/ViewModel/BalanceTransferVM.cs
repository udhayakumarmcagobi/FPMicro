using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBMicor.Web.Application.ViewModel
{
    public class BalanceTransferVM
    {
        public BalanceTransferVM()
        {
            BankDetailsList = new List<ViewModel.BankDetailsVM>();
            bankSelected = new ViewModel.BankDetailsVM();
            customer = new ViewModel.CustomerVM();
        }
        public string LoanAmount { get; set; }
        public List<BankDetailsVM> BankDetailsList { get; set; }
        public BankDetailsVM bankSelected { get; set; }
        public string selectedBankID { get; set; }
        public bool IsTopUp { get; set; }
        public string  TopUpAmount { get; set; }
        public CustomerVM customer { get; set; }
    }
}