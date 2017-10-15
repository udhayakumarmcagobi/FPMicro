using FBMicro.Web.Application.Core;
using FBMicro.Web.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FBMicro.Web.Application.Controllers
{
    public class BalanceTransferController : Controller
    {
        private readonly BalanceTransferService balanceTransferService;

        public BalanceTransferController()
        {
            balanceTransferService = new Core.BalanceTransferService();
        }

        // GET: BalanceTransfer
        public ActionResult Index()
        {
            var balanceTransferVM = balanceTransferService.GetBalanceTransferEmpty();
            return View(balanceTransferVM);
        }

        [HttpPost]
        public ActionResult Checkout(BalanceTransferVM balanceTransferVM)
        {
            try
            {
                var isResult = balanceTransferService.SaveUserbalanceTransferDetails(balanceTransferVM);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }

            return RedirectToAction("Index", "Offers", new
                RouteValueDictionary(new
                {
                    bankID = balanceTransferVM.selectedBankID,
                    loanAmount = balanceTransferVM.LoanAmount
                }));
        }
    }
}