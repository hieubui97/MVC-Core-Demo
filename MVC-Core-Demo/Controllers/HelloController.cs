using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Core_Demo.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public string Welcome(string name, int id = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, id = {id}");
        //}

        public IActionResult Welcome(string name, int id = 3)
        {
            ViewBag.Name = name;
            ViewBag.Id = id;

            return View();
        }
    }
}
