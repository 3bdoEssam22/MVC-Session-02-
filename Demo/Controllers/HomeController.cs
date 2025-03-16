using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        //BaseURL/Home/Index
        public IActionResult Index()
        {
            ///return View("Hamada"); // return view with the pecific name.
            ///return View(new Movie()); //Take model to bind it with view.
            ///return View("Hamada", new Movie()); // return view with the pecific name Take model to bind it with view.0

            return View(); //return view with the same name of Actins.

        }

        //BaseURL/Home/Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        //BaseURL/Home/AboutUs
        public IActionResult AboutUs()
        {
            return View();
        }

        //BaseURL/Home/ContactUs
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
