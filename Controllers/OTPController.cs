using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWebMVCTest.Controllers
{
    public class OTPController : Controller
    {
        // GET: OTP
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GenerateOTP()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GenerateNumericOTP()
        {
            string numbers = "0123456789";
            Random objrandom = new Random();
            string strrandom = string.Empty;

            string username = Request["user"].ToString();
            ViewBag.usr = username;
                        
            DateTime dataCreare;
            for (int i = 0; i < 5; i++)
            {
                int temp = objrandom.Next(0, numbers.Length);
                strrandom += temp;
            }
            ViewBag.otp = strrandom;

            dataCreare = DateTime.UtcNow;

            ViewBag.dat = dataCreare;
            return View("GenerateOTP");
        }       
    }
}