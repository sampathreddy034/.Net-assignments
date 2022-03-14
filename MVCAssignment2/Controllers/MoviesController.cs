using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAssignment2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        MoviedbEntities moviedbEntities=new MoviedbEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            List<Movie> movies = moviedbEntities.Movies.ToList<Movie>();
            return View(movies);

        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movie cre)
        {
            moviedbEntities.Movies.Add(cre);
            moviedbEntities.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Movie cat = moviedbEntities.Movies.Find(id);
            return View(cat);
        }
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            Movie movies = moviedbEntities.Movies.Find(movie.mid); 
            movies.moviename = movies.moviename;
            movies.dateofrelease= movies.dateofrelease;
            moviedbEntities.SaveChanges();
            return RedirectToAction("List");
        }
        public ActionResult Details(int id)
        {
            Movie movie = moviedbEntities.Movies.Find(id);
            return View(movie);
        }
        public ActionResult Delete(int id)
        {
            Movie movie = moviedbEntities.Movies.Find(id);
            moviedbEntities.Movies.Remove(movie);
            moviedbEntities.SaveChanges();
            return RedirectToAction("List");
        }
        public ActionResult GetMovieByYear(string year)
        {
            List<Movie> movie=(from c in moviedbEntities.Movies
                        where c.dateofrelease.ToString().Contains(year)
                        select c).ToList();
            return View(movie);
        }
    }
}