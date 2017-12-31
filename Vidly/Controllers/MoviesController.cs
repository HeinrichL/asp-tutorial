using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private List<Movie> movies = new List<Movie>
        {
            new Movie(){Name = "Shrek"},
            new Movie(){Name = "Wall-e"}
        };

        //GET /movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            return View(new List<Movie>());
        }

        [Route("movies/released/{year:range(1900, 2017)}/{month:range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"year={year} --- month={month}");
        }

        
    }
}