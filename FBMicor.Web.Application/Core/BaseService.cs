using FBMicro.Web.Application.ViewModel;
using FBMicro.Data.DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBMicro.Web.Application.Core
{
    public class BaseService
    {
        private BankMasterRepository bankMasterRepository;

        protected List<BankDetailsVM> GetBankDetailsVM()
        {
            var bankDetailsListVM = new List<BankDetailsVM>();

            bankMasterRepository = new BankMasterRepository();

            var bankMasterDetails = bankMasterRepository.GetAll();

            if (bankMasterDetails == null || !bankMasterDetails.Any()) return bankDetailsListVM;

            bankMasterDetails.ToList().ForEach(x =>
            {
                var bankDetailVM = AutoMapper.Mapper.Map<BankDetailsVM>(x);

                bankDetailsListVM.Add(bankDetailVM);
            });

            return bankDetailsListVM;
        }

    }
}