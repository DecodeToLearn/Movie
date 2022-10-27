using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.Data;
using Example.Models;
using Microsoft.AspNetCore.Mvc;

namespace Example.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? id)
        {
            //MovieCategoryModel model = new MovieCategoryModel();
            //model.Movies = MovieRepository.Movies;
            //model.Categories = CategoryRepository.Categories;
            var movies = MovieRepository.Movies;
            if (id != null)
            {
                movies = movies.Where(i => i.CategoryId == id).ToList();
            }
            return View(movies);
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            //MovieCategoryModel model = new MovieCategoryModel();
            //model.Categories = CategoryRepository.Categories;
            //model.movie = MovieRepository.GetById(id);
            return View(MovieRepository.GetById(id));
        }
    }
}