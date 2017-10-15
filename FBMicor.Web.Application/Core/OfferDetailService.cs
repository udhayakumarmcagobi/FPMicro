using FBMicro.Web.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBMicro.Web.Application.Core
{
    public class OfferDetailService : BaseService
    {
        public OfferDetailService() { }

        public List<OfferDetailsVM> GetOfferDetails(int bankID, string loanAmount)
        {
            var bankDetailsList = GetBankDetailsVM();

            if (bankDetailsList == null || !bankDetailsList.Any()) return new List<OfferDetailsVM>();

            var offerList = new List<OfferDetailsVM>();

            var bankDetail = bankDetailsList.Where(x => x.BankID.Equals(Convert.ToString(bankID))).FirstOrDefault();

            bankDetailsList.ForEach(x =>
            {
                var offerDetail = new OfferDetailsVM()
                {
                     bankDetail = x,
                     OfferAmount = CalculateOfferAmount(x.offerPercentage, loanAmount)
                };

                offerList.Add(offerDetail);
            });

            offerList = GetCustomOrderOffers(offerList, bankDetail.BankName);

            return offerList;
        }

        private string CalculateOfferAmount(string offerPercentage, string loanAmount)
        {
            var result = Convert.ToDecimal(offerPercentage) / 100 * Convert.ToDecimal(loanAmount);

            return result.ToString();
        }

        private List<OfferDetailsVM> GetCustomOrderOffers(List<OfferDetailsVM> offerDetails,  string bankName)
        {
            return offerDetails.OrderBy(x => x.bankDetail.BankName.StartsWith(bankName) ? 1 : 2).ToList();                
        }
    }
}