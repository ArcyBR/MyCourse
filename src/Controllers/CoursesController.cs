using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace src.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index(){
            return Content("sono la Index della Courses");
        }

        public IActionResult Detail(string id){
            return Content($"Sono Detail delle Courses, ho ricevuto l'Id {id}");
        }
    }
}