﻿using FBMicor.Web.Application.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FBMicor.Web.Application.Controllers
{
    public class HomeLoanController : Controller
    {
        private readonly HomeLoanService homeLoanService;

        public HomeLoanController()
        {
            homeLoanService = new Core.HomeLoanService();
        }

        // GET: HomeLoan
        public ActionResult Index()
        {
            var homeLoanVM = homeLoanService.GetHomeLoanEmpty();
            return View(homeLoanVM);
        }
    }
}