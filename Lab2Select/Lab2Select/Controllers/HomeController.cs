using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab2Select.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.val = true;
            return View();
        }

        [HttpPost]
        public IActionResult Index(int select)
        {
            if(select == 1)
            {
                ViewBag.val = false;
            }
            else
            {
                ViewBag.val = true;
            }
            return View();
        }
        
    }
}
