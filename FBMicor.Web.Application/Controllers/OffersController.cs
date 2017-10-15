using FBMicro.Web.Application.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FBMicro.Web.Application.Controllers
{
    public class OffersController : Controller
    {
        private readonly BankLoanDetailService bankLoanDetailService;

        public OffersController()
        {
            bankLoanDetailService = new BankLoanDetailService();
        }
        // GET: Offers
        public ActionResult Index()
        {
            var bankLoanDetailList = bankLoanDetailService.GetBankLoanDetailList();
            return View(bankLoanDetailList);
        }
    }
}