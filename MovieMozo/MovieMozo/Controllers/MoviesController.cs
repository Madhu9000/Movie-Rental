using MovieMozo.Models;
using MovieMozo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieMozo.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, MovieName = "Shrek" },
                new Movie { Id = 2, MovieName = "Wall-e" }
            };
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { MovieName = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { CustomerName = "Customer 1" },
                new Customer { CustomerName = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}