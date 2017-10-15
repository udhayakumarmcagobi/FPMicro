using FBMicro.Web.Application.Core;
using FBMicro.Web.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FBMicro.Web.Application.Controllers
{
    public class HomeLoanController : Controller
    {
        private readonly HomeLoanService homeLoanService;

        public HomeLoanController()
        {
            homeLoanService = new Core.HomeLoanService();
        }

        // POST: HomeLoan
        public ActionResult Index()
        {
            var homeLoanVM = homeLoanService.GetHomeLoanEmpty();
            return View(homeLoanVM);
        }

        [HttpPost]
        public ActionResult Checkout(HomeLoanVM homeLoanVM)
        {
            try
            {
                var isResult = homeLoanService.SaveUserHomeLoanDetails(homeLoanVM);                
            }
            catch(Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }

            return RedirectToAction("Index", "Offers");
        }
    }
}