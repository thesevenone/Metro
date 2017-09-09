using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PengelolaanPegawai.Controllers
{
    public class MetroController : Controller
    {
        // GET: Metro
        public ActionResult Index()
        {
            return View();
        }
        //get : Metro/UI
        public ActionResult UI()
        {
            return View();
        }
        //get : Metro/Forms
        public ActionResult Forms()
        {
            return View();
        }
        //get : Metro/Charts
        public ActionResult Charts()
        {
            return View();
        }
        //get : Metro/Tables
        public ActionResult Tables()
        {
            return View();
        }
    }
}