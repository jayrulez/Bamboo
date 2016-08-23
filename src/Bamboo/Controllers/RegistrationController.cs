﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bamboo.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Bamboo.Controllers
{
    public class RegistrationController : Controller
    {

        private BambooContext bambooContext;

        public RegistrationController(BambooContext bambooContext)
        {
            this.bambooContext = bambooContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View("~/Views/Registration/Registration.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public string Register(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
               // model.BirthDate = model.BirthDate.Date;
                //bambooContext.Registrations.Add(model);
                //bambooContext.SaveChanges();
                return "done";
            }

            return "error";
        }
    }
}
