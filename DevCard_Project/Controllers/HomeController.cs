using DevCard_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private readonly List<Service> _services = new List<Service>
        {
            new Service(1,"نقره ای"),
            new Service(2,"طلایی"),
            new Service(3,"پلاتین"),
            new Service(4,"الماس"),
        };

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new ContactForm
            {
                Services = new SelectList(_services,"Id","Name")
            };
            return View(model);
        }
        //[HttpPost]
        //public IActionResult Contact(IFormCollection model)
        //{
        //    var name = model["name"];
        //    return Json(Ok());
        //}

        [HttpPost]
        public IActionResult Contact(ContactForm model)
        {
            model.Services = new SelectList(_services, "Id", "Name");
            if (!ModelState.IsValid)
            {
                ViewBag.success = null;
                ViewBag.error = "اطلاعات وارد شده صحیح نمی باشد.";
                return View(model);
            }

            ModelState.Clear();

            model = new ContactForm()
            {
                Services = new SelectList(_services, "Id", "Name")
            };

            ViewBag.success = "پیام شما با موفقیت ثبت شد.با تشکر";
            return View(model);

            
        }
 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
