using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PengelolaanPegawai.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        //get:login
        public ActionResult Login()
        {
            return View();
        }
        //post:login
        /*[HttpPost]
        public ActionResult Login(LoginViewModel data)
        {
            return View();
        }
        */
        //get:PageNotFound
        public ActionResult PageNotFound()
        {
            return View();
        }
    }
}