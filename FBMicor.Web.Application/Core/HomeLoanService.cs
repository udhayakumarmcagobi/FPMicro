using AutoMapper;
using FBMicor.Web.Application.ViewModel;
using FBMicro.Data.DataProvider;
using FBMicro.Data.DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBMicor.Web.Application.Core
{
    public class HomeLoanService : BaseService
    {
        private readonly UserDetailRepository userDetailRepository;
        private readonly UserHomeLoanRepository userHomeLoanRepository;

        public HomeLoanService()
        {
            userDetailRepository = new UserDetailRepository();
            userHomeLoanRepository = new UserHomeLoanRepository();
        }

        public HomeLoanVM GetHomeLoanEmpty()
        {
            var homeLoanVM = new HomeLoanVM()
            {
                  BankDetailsList = GetBankDetailsVM()
            };

            return homeLoanVM;
        }   
        
        public bool SaveUserHomeLoanDetails(HomeLoanVM homeLoanVM)
        {            
            UserDetail userDetails = Mapper.Map<UserDetail>(homeLoanVM.customer);

            var isResult = userDetailRepository.CreateUser(userDetails);

            if (isResult)
            {
                homeLoanVM.customer.CustomerID = Convert.ToString(userDetails.Id);

                 UserHomeLoanDetail userHomeLoanDetails = Mapper.Map<UserHomeLoanDetail>(homeLoanVM);

                isResult = userHomeLoanRepository.CreateUserHomeLoan(userHomeLoanDetails);
                
            }

            //Send Email

            return isResult;
        }
       
    }
}