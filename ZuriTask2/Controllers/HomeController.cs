using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using ZuriTask2.Models;

namespace ZuriTask2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
        [HttpPost]
        public ActionResult Create(Form form)
        {
            MailAddress mail = new MailAddress("oluwatobilobalayeuthman@gmail.com");
            MailMessage message = new MailMessage(form.Email, "oluwatobilobalayeuthman@gmail.com", "Zuri", form.Message);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);


            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return Content("Message Sent");

        }
    }
}