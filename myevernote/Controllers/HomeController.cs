using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace myevernote.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MyEvernote.BusinessLayer.Test test = new MyEvernote.BusinessLayer.Test();
            //test.TestList();
            //test.TestInsert();
            //test.TestUpdate();
            //test.TestDelete();

            return View();
        }
    }
}

