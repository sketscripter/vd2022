using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vd2022.Models;
using Vd2022.ViewModels;

namespace Vd2022.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie{Id=1,Name ="Toy Story"},
                new Movie{Id=2,Name ="Shrek"}
            };

            ViewBag.MoviesList = movies;
            return View();
        }

        public ActionResult Detail(int id)
        {
            var movies = new List<Movie>
            {
                new Movie{Id=1,Name ="Toy Story"},
                new Movie{Id=2,Name ="Shrek"}
            };
            ViewBag.MovieDetail = movies.ElementAt(id-1);
            return View();
        }

        public ActionResult Random()
        {
            var movie = new Movie
            {
                Id = 1,
                Name = "shrek"
            };

            var customers = new List<Customer>
            {
                new Customer{Id=1, Name= "Samed"},
                new Customer{Id=2, Name= "Hamed"},
                new Customer{Id=3, Name= "Kamed"},
                new Customer{Id=4, Name= "Pamed"},

            };

            var randommovie = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers

            };

            ViewBag.UicMovies = movie;
            ViewData["Movie"] = movie;
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "Name" });
            return View(randommovie);
        }
        [Route ("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ReleaseDate(int year, int month)
        {
            return Content(year +"/"+ month );
        }
    }
}