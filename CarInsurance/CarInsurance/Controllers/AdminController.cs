using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = (from c in db.Insurees
                                select c).ToList();
                var insureeVms = new List<InsureeVm>();
                foreach (var insuree in insurees)
                {
                    var insureeVm = new InsureeVm();
                    insureeVm.Id = insuree.Id;
                    insureeVm.FirstName = insuree.FirstName;
                    insureeVm.LastName = insuree.LastName;
                    insureeVm.EmailAddress = insuree.EmailAddress;
                    insureeVm.DateOfBirth = insuree.DateOfBirth;
                    insureeVm.CarYear = insuree.CarYear;
                    insureeVm.CarModel = insuree.CarModel;
                    insureeVm.DUI = insuree.DUI;
                    insureeVm.SpeedingTickets = insuree.SpeedingTickets;
                    insureeVm.CoverageType = insuree.CoverageType;
                    insureeVm.Quote = insuree.Quote;
                }
            }
            return View();
        }
        public ActionResult AdminIndex()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = (from c in db.Insurees
                                select c).ToList();
                var insureeVms = new List<InsureeVm>();
                foreach (var insuree in insurees)
                {
                    var insureeVm = new InsureeVm();
                    insureeVm.Id = insuree.Id;
                    insureeVm.FirstName = insuree.FirstName;
                    insureeVm.LastName = insuree.LastName;
                    insureeVm.EmailAddress = insuree.EmailAddress;
                    insureeVm.DateOfBirth = insuree.DateOfBirth;
                    insureeVm.CarYear = insuree.CarYear;
                    insureeVm.CarModel = insuree.CarModel;
                    insureeVm.DUI = insuree.DUI;
                    insureeVm.SpeedingTickets = insuree.SpeedingTickets;
                    insureeVm.CoverageType = insuree.CoverageType;
                    insureeVm.Quote = insuree.Quote;
                }
            }
            return View();
        }
    }
}