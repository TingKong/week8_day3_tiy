using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using weather.Models;

namespace weather.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Weather2");
        }

        public JsonResult GetWeather()
        {
            weather_stuff myWeather = new weather_stuff();
            return Json(myWeather.GetCurrentWeather(), JsonRequestBehavior.AllowGet);

        }
    }
}