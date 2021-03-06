﻿using System;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using System.Web.UI.WebControls;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageMovies))
            {
                return View("List");
            }
            else
            {
                return View("ReadOnlyList");
            }
            
            
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel()
            {
                Genres = genres
            };
            return View("MovieForm",viewModel);
        }

        [HttpPost]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = _context.Genres.ToList()
                };
                return View("MovieForm", viewModel);
            }

            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieFromDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieFromDb.GenreId = movie.GenreId;
                movieFromDb.Name = movie.Name;
                movieFromDb.NumberInStock = movie.NumberInStock;
                movieFromDb.ReleaseDate = movie.ReleaseDate;
            }

            _context.SaveChanges();
            
            return RedirectToAction("Index");
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m=>m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            var viewModel = new MovieFormViewModel(movie)
            {
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }
        
        /*
        [Route("movies/{name}/actor/{actorId}")]
        public ActionResult TryAMultiAction(string name,int actorId) 
        {
            return Content(String.Format("Movie name is {0}. Actor Id is {1}",name,actorId));
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult MoviesByReleaseDate(int year, int month)
        {
            return Content(String.Format("Year = {0} Month = {1}", year, month));
        }
        */
    }
}