﻿using Microsoft.AspNetCore.Mvc;

namespace EFCoreSideKick.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly DataContext _dataContext;
        public CategoryController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult List()
        {
            var values = _dataContext.Categories.ToList();
            return View(values);
        }
    }
}
