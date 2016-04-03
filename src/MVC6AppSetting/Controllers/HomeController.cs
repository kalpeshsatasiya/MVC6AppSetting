using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.OptionsModel;

namespace MVC6AppSetting.Controllers
{
    public class HomeController : Controller
    {
        private readonly string _webSiteURL;
        private readonly string _webSiteTitle;
        public HomeController(IOptions<AppSettings> settings)
        {
            _webSiteTitle = settings.Value.WebSiteTitle;
            _webSiteURL = settings.Value.WebSiteURL;
        }
        public IActionResult Index()
        {
            ViewBag.WebSiteTitle = _webSiteTitle;
            ViewBag.WebSiteURL = _webSiteURL;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
