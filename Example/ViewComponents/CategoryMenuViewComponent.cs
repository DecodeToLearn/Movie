using System;
using Example.Data;
using Microsoft.AspNetCore.Mvc;

namespace Example.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["action"].ToString() == "Index")
                ViewBag.CategorySelected = RouteData.Values["id"];
            return View(CategoryRepository.Categories);
        }
    }
}

