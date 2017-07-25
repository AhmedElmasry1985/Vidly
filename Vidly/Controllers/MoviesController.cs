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
        List<Movie> _movies = new List<Movie>
        {
            new Movie {Id = 1,Name = "Shrek!"},
            new Movie { Id = 2,Name = "Titanic"}
        };
        public ActionResult Index()
        {
            var vm = new MoviesViewModel
            {
                Movies = _movies
            };
            return View(vm);
        }
    }
}