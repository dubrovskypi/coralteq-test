using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cor.Models;

namespace Cor.Controllers
{
    public class RegisterController : Controller
    {
        public static NewUser RegisterUser = new NewUser();

        static RegisterController()
        {

        }

        //private static NewUser RegisterUser;

        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Index(ContactInfoViewModel model)
        //{
        //    return View();
        //}

        [HttpGet]
        public ActionResult Step2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Step2(ContactInfoViewModel model)
        {
            RegisterUser.Salutation = model.Salutation;
            RegisterUser.FName = model.FName;
            RegisterUser.MName = model.MName;
            RegisterUser.LName = model.LName;
            RegisterUser.Company = model.Company;
            RegisterUser.Title = model.Title;
            RegisterUser.Email = model.Email;
            RegisterUser.ConfirmEmail = model.ConfirmEmail;
            RegisterUser.Phone = model.Phone;
            RegisterUser.Fax = model.Fax;
            RegisterUser.Mobile = model.Mobile;
            return View();
        }

        [HttpGet]
        public ActionResult Step3()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Step3(BusinessAreaViewModel model)
        {
            List<string> businessArea = new List<string>();
            if (model != null) RegisterUser.BusinessArea = model.BusinessArea;
            else RegisterUser.BusinessArea = businessArea;
            return View();
        }

        [HttpGet]
        public ActionResult Step4()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Step4(AddressInfoViewModel model)
        {
            UserAddress uaddress = new UserAddress();
            uaddress.Country = model.Country;
            uaddress.OfficeName = model.OfficeName;
            uaddress.Address = model.Address;
            uaddress.PostalCode = model.PostalCode;
            uaddress.City = model.City;
            uaddress.State = model.State;
            RegisterUser.Address = uaddress;
            return View();
        }

        [HttpPost]
        public ActionResult Step5(PasswordViewModel model)
        {
            RegisterUser.Password = model.Password;
            RegisterUser.ConfirmPassword = model.ConfirmPassword;
            return View(RegisterUser);
        }
    }
}