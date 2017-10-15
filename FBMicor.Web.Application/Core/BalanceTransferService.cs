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
    public class BalanceTransferService : BaseService
    {
        private readonly UserDetailRepository userDetailRepository;
        private readonly UserBalanceTransferRepository userBalanceTransferRepository;

        public BalanceTransferService()
        {
            userDetailRepository = new UserDetailRepository();
            userBalanceTransferRepository = new UserBalanceTransferRepository();
        }

        public BalanceTransferVM GetBalanceTransferEmpty()
        {
            var balanceTransferVM = new BalanceTransferVM()
            {
                BankDetailsList = GetBankDetailsVM()
            };

            return balanceTransferVM;
        }

        public bool SaveUserbalanceTransferDetails(BalanceTransferVM balanceTransferVM)
        {
            UserDetail userDetails = Mapper.Map<UserDetail>(balanceTransferVM.customer);

            var isResult = userDetailRepository.CreateUser(userDetails);

            if (isResult)
            {
                balanceTransferVM.customer.CustomerID = Convert.ToString(userDetails.Id);

                UserBalanceTransferDetail userBalanceTransferDetails = Mapper.Map<UserBalanceTransferDetail>(balanceTransferVM);

                isResult = userBalanceTransferRepository.CreateUserBalanceTransfer(userBalanceTransferDetails);

            }

            //Send Email

            return isResult;
        }

    }
}