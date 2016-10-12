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
        
        [HttpGet]
        public ActionResult Step1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Step1(ContactInfoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
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
            return RedirectToAction("Step2");
        }

        [HttpGet]
        public ActionResult Step2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Step2(List<string> names)
        {
            List<string> newBusinessArea = new List<string>();
            for (int i = 0; i < names.Count; i++)
            {
                newBusinessArea.Add(names[i]);
            }
            RegisterUser.BusinessArea = newBusinessArea;
            return RedirectToAction("Step3");
        }
        

        [HttpGet]
        public ActionResult Step3()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Step3(AddressInfoViewModel model)
        {
            UserAddress uaddress = new UserAddress();
            uaddress.Country = model.Country;
            uaddress.OfficeName = model.OfficeName;
            uaddress.Address = model.Address;
            uaddress.PostalCode = model.PostalCode;
            uaddress.City = model.City;
            uaddress.State = model.State;
            RegisterUser.Address = uaddress;
            return RedirectToAction("Step4");
        }

        [HttpGet]
        public ActionResult Step4()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Step4(PasswordViewModel model)
        {
            RegisterUser.Password = model.Password;
            RegisterUser.ConfirmPassword = model.ConfirmPassword;
            return RedirectToAction("Step5");
        }
        
        public ActionResult Step5()
        {
            return View();
        }
    }
}