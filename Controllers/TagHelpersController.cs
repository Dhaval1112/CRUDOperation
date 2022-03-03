using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOperation.Controllers
{
    public class TagHelpersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
