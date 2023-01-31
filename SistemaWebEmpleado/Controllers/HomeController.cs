using System;
using Microsoft.AspNetCore.Mvc;

namespace OperaWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nombre = "Bienvenido al sistema Empleados";
            ViewBag.Fecha = DateTime.Now.ToString();
            return View();
        }
    }

}