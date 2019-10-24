using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RazorEnvironment.Model;

namespace RazorEnvironment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           Student objStudent = new Student();
            //objStudent.Name = "Nguyên Lộc";
            objStudent.Age = 22;
            return View(objStudent);
        }
    }
}