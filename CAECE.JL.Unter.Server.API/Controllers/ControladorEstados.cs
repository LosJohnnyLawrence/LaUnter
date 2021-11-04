using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.API.Controllers
{
    public class ControladorEstados : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
