using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vd2022.Models;

namespace Vd2022.Controllers.API
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/movies
        [HttpGet]
        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }

        // GET /api/movies/1
        [HttpGet]
        public Movie GetMovie(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return movie;
        }

        //POST
        [HttpPost]
        public Movie CreateMovie(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return movie;
        }

        //PUT api/movies/1
        [HttpPut]
        public void UpdateMovie(int id, Movie movie)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            var movieinDb = _context.Movies.Find(id);
            if (movieinDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            movieinDb.Name = movie.Name;
            movieinDb.GenreId = movie.GenreId;
            movieinDb.ReleaseDate = movie.ReleaseDate;
            movieinDb.Stock = movie.Stock;
            movieinDb.Producer = movie.Producer;

            _context.SaveChanges();

        }

        //GET /api/movies/1
        [HttpDelete]
        public void DeleteCustommer(int id)
        {
            var movieinDb = _context.Movies.Find(id);
            if (movieinDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            _context.Movies.Remove(movieinDb);
            _context.SaveChanges();

        }


    }
}


