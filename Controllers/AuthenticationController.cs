using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Trividi_Booking.Models;
using Trividi_Booking.Ultils;

namespace Trividi_Booking.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly Net_BookingContext _db;

        public AuthenticationController(Net_BookingContext db)
        {
            _db = db;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string username, string HashPassword)
        {
            if (username == null || HashPassword == null)
            {
                ViewBag.Error = "Account is not valid!";
                return View();
            }
            Account acc = _db.Accounts.Where(a => a.Username == username && a.HashPassword == PasswordEncryption.MD5Hash(HashPassword)).FirstOrDefault();
            if (acc == null)
            {
                ViewBag.Error = "Username or password is incorect!";
                return View();
            }
            else if (acc.Status != true)
            {
                ViewBag.Error = "Your account was blocked!";
                return View();
            }
            else
            {
                HttpContext.Session.SetInt32("roleid", (int)acc.RoleId);
                HttpContext.Session.SetString("name", acc.FullName);
                HttpContext.Session.SetInt32("id", acc.Uid);
                if(acc.IdHotel != null){
                HttpContext.Session.SetInt32("idH", (int)acc.IdHotel);

                }

            }
            return RedirectToAction("Index", "Hotel");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(string name, string email, string phone, string username, string pass, string repass)
        {
            if (!Validation.ValidEmail(email))
            {
                ViewBag.Error = "Email is invalid!";
                return View();
            }
            Account a2 = _db.Accounts.Where(a => a.Email == email).FirstOrDefault();
            if (a2 != null)
            {
                ViewBag.Error = "Email was used!";
                return View();
            }
            if (!Validation.ValidMobileNumber(phone))
            {
                ViewBag.Error = "Phone number is invalid!";
                return View();
            }
            Account a1 = _db.Accounts.Where(a => a.Phone == phone).FirstOrDefault();
            if (a1 != null)
            {
                ViewBag.Error = "Phone number was used!";
                return View();
            }
            if (pass != repass)
            {
                ViewBag.Error = "Password and repassword does not match!";
                return View();
            }
            Account acc = new Account();
            acc.FullName = name;
            acc.Status = true;
            acc.Email = email;
            acc.RoleId = 1;
            acc.Username = username;
            acc.Phone = phone;
            acc.HashPassword = PasswordEncryption.MD5Hash(pass);
            _db.Accounts.Add(acc);
            _db.SaveChanges();
            Account newAcc = _db.Accounts.Where(a => a.Username == username).FirstOrDefault();
            HttpContext.Session.SetInt32("roleid", (int)newAcc.RoleId);
            HttpContext.Session.SetString("name", newAcc.FullName);
            HttpContext.Session.SetInt32("id", newAcc.Uid);
            if (newAcc.IdHotel!= null)
            {
            HttpContext.Session.SetInt32("idH", (int)newAcc.IdHotel);
            }
            return RedirectToAction("Index", "Hotel");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("roleid");
            HttpContext.Session.Remove("name");
            HttpContext.Session.Remove("id");
            if(HttpContext.Session.GetInt32("idH")!= null) {
                HttpContext.Session.Remove("idH");
            }
            return RedirectToAction("Index", "Hotel");
        }

        public IActionResult GetPassword(string err, string success)
        {
            if(err!=null) ViewBag.Err = err;
            if(success!=null)ViewBag.Success = success;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetPassword2(string email)
        {
            if(!Validation.ValidEmail(email)){
                return RedirectToAction("GetPassword", "Authentication", new{err = "Email is not valid!"});
            }
            string password = RandomString.GeneratePassword(6);
            Account acc = _db.Accounts.Where(a => a.Email == email).FirstOrDefault();
            acc.HashPassword = PasswordEncryption.MD5Hash(password);
            _db.Accounts.Update(acc);
            _db.SaveChanges();
            return RedirectToAction("GetPassword", "Authentication", new{success = "Your new password is: "+password});
        }
        
        

    }
}