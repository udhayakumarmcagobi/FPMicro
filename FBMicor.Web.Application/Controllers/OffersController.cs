using FBMicro.Web.Application.Core;
using FBMicro.Web.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FBMicro.Web.Application.Controllers
{
    public class OffersController : Controller
    {
        private readonly OfferDetailService offerDetailService;

        public OffersController()
        {
            offerDetailService = new Core.OfferDetailService();
        }
        // GET: Offers
        public ActionResult Index(int bankID, string loanAmount)
        {
            var offerDetailsList = offerDetailService.GetOfferDetails(bankID, loanAmount);
            return View(offerDetailsList);
        }
    }
}