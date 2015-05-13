using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCBaker.Models;

namespace MCBaker.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CakesAndCookies()
        {
            Images images = new Images();
            images.getImages("cakesandcookies");
            return View(images);
        }

        public ActionResult Bread()
        {
            Images images = new Images();
            images.getImages("bread");
            return PartialView(images);
        }

        public ActionResult AndMore()
        {
            Images images = new Images();
            images.getImages("andmore");
            return PartialView(images);
        }

        public ActionResult Contact()
        {
            return View();
        }

    }
}
