using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABC.Data;
using ABC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ABC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly DataContext _context;
        public CategoryController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Category()
        {
            var category = _context.BookCategories.ToList();
            return View(category);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(BookCategory bookCategory)
        {
            _context.BookCategories.Add(bookCategory);
            _context.SaveChanges();
            return RedirectToAction("Category");
        }
        [HttpGet]
        public IActionResult RemoveCategory(int Id)
        {
            var category = _context.BookCategories.Find(Id);
           
            return View(category);
            
        }
        [HttpPost]
        public IActionResult RemoveCategoryConfirmed(int Id)
        {
            var Category = _context.BookCategories.Find(Id);
            if (Category == null)
            {
                return NotFound();
            }
            else
            {

            }
           _context.BookCategories.Remove(Category);
            _context.SaveChanges();
            return View();
        }
   
    }
}
