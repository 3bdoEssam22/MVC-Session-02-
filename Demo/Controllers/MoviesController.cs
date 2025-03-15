using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class MoviesController : Controller
    {
        //BaseURL/Movies/Index
        public string Index()
        {
            return ("Hello from Index");
        }

        //BaseURL/Movies/GetMovies?id=10&name=Film
        [HttpGet]
        public string GetMovies(int? id, string name)
        {
            return $"Movie Id: {id}, Name: {name}";
        }
    }
}
