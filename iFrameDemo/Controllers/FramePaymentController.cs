using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iFrameDemo.Controllers
{
    public class FramePaymentController : Controller
    {

        public ActionResult Index()
        {
            //return View();
         
            return View("Index", "~/Views/Shared/_LayoutLean.cshtml"); 
        }


        [HttpPost]
        public string Pay(string someArgument = "default123") {
            return someArgument;
        }

        [HttpPost]
        public string Pay1(string id = "defaultID")
        {
            return id;
        }
    }
}