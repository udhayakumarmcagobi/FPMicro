using AutoMapper;
using FBMicro.Web.Application.ViewModel;
using FBMicro.Data.DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBMicro.Web.Application.Core
{
    public class BankLoanDetailService
    {
        private readonly BankLoanDetailRepository bankLoanDetailRepository;

        public BankLoanDetailService()
        {
            bankLoanDetailRepository = new BankLoanDetailRepository();
        }

        public List<BankLoanDetailsVM> GetBankLoanDetailList()
        {
            var bankLoanDetailList = bankLoanDetailRepository.GetAll();

            var bankLoanDetailsVMList = Mapper.Map<List<BankLoanDetailsVM>>(bankLoanDetailList);
            return bankLoanDetailsVMList;
        }
    }
}