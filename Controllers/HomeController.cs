using CRUDOperation.Data;
using CRUDOperation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOperation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CrudDBContext _crudDBContext;

        
        public HomeController(ILogger<HomeController> logger, CrudDBContext crudDBContext)
        {
            _logger = logger;
            this._crudDBContext = crudDBContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AllEmployees()
        {
            var employees=_crudDBContext.tblEmployees.ToList();
            return View(employees);
        }

        public IActionResult Edit(int id)
        {
            var employee = _crudDBContext.tblEmployees.Find(id);
            return View(employee);
        }
        
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            _crudDBContext.tblEmployees.Update(employee);
            _crudDBContext.SaveChanges();
            return RedirectToAction("AllEmployees");
        }

        public IActionResult Delete(int id)
        {
            var product = _crudDBContext.tblEmployees.Find(id);

            return View(product);
        }

        public IActionResult DeleteEmployee(int id)
        {
            var product = _crudDBContext.tblEmployees.Remove(_crudDBContext.tblEmployees.Find(id));
            _crudDBContext.SaveChanges();
            return RedirectToAction("AllEmployees");
        }


        public IActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEmployee(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _crudDBContext.tblEmployees.Add(emp);
                _crudDBContext.SaveChanges();

                return RedirectToAction("AllEmployees");
            }

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
