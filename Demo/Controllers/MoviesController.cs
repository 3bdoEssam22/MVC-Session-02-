using Demo.Models;
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

        #region example 01
        ////BaseURL/Movies/GetMovie?id=10&name=Film
        //[HttpGet]
        //public ContentResult GetMovie(int? id, string name)
        //{
        //    //ContentResult result = new ContentResult();
        //    //result.Content = $"Movie Id: {id},</br> Name: {name}";
        //    //result.ContentType = "text/html";
        //    //result.StatusCode = 200;

        //    return Content($"Movie ID: {id}</br> Name: {name}", "text/html");
        //    //return $"Movie Id: {id}, Name: {name}";
        //}

        #endregion

        //BaseURL/Movies/GetMovie?id=10&name=Film
        [HttpGet]
        public IActionResult GetMovie(int? id, string name)
        {
            //ID = 0 => Bad request
            // ID < 10 => Not found
            // ID >= 10 => return movie

            if (id == 0)
                return BadRequest();
            else if (id < 10)
                return NotFound();
            else
                return Content($"Movie ID: {id}</br> Name: {name}", "text/html");
        }

        public IActionResult TestRedirect()
        {
            return RedirectToRoute("Default", new { controller = "Movies", action = nameof(GetMovie), id = 10, name = "Tarazan" });
            //return RedirectToAction(nameof(GetMovie), "Movies", new { id = 10, name = "tarazan" });
            //return Redirect("https://localhost:7076/Movies/GetMovie?id=10&name=film");
            //return Redirect("https://www.google.com");
        }

        public IActionResult TestModelBinding([FromQuery] int Id, string Name)
        {
            return Content($"Hello {Name}</br> ID: {Id}", "text/html");
        }

        [HttpPost]
        public IActionResult AddMovie([FromBody] Movie movie)
        {
            if (movie is null)
                return BadRequest();
            else
                return Content($"Movie ID: {movie.ID}</br> Name: {movie.title}", "text/html");
        }

        [HttpPost]
        public IActionResult AddMovie02([FromHeader] int Id, [FromHeader] string Title) //FromHeader doesn't work with complex types
        {
            return Content($"Movie ID: {Id}</br> Name: {Title}", "text/html");
        }

        [HttpGet]
        public IActionResult AddMovie03(int Id, Movie movie, string Title, int[] arr)
        {
            return Content($"");
        }


    }
}
