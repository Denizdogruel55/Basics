using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers;

public class CourseController : Controller
{
    public IActionResult Index()
    {
        var kurs = new Course();
        kurs.Id = 1;
        kurs.Title = "AspNetCore";
        kurs.Description = "Guzel kurs";
        kurs.Images = "1.webp";
        return View(kurs);
    }public IActionResult List()
    {

        return View(Repisotory.Courses);
    }
        public IActionResult Details(int id)
    {
        
  
        return View(Repisotory.GetById(id));
    }
} 