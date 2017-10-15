using FBMicor.Web.Application.ViewModel;
using FBMicro.Data.DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBMicor.Web.Application.Core
{
    public class HomeLoanService : BaseService
    {
        private BankMasterRepository bankMasterRepository;
        public HomeLoanVM GetHomeLoanEmpty()
        {
            bankMasterRepository = new BankMasterRepository();
            var bankMasterDetail = bankMasterRepository.GetAll();

            var homeLoanVM = new HomeLoanVM()
            {
                  BankDetailsList = GetBankDetailsVM()
            };

            return homeLoanVM;
        }        
    }
}