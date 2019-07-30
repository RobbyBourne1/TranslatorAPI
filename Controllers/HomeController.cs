using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TranslatorAPI.Models;

namespace TranslatorAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public void Input(string translated)
        {
            var inputText = Request.Form["Input"];

            Console.WriteLine(inputText);

            RedirectToAction("Index", "HomeController");
        }
    }
}
