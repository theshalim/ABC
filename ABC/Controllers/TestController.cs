using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABC.Data;
using ABC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ABC.Controllers
{

    public class TestController : Controller
    {
        private readonly DataContext _context;
        public TestController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Test = _context.Tests.ToList();
            return View(Test);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Test test)
        {
            _context.Tests.Add(test);
            _context.SaveChanges();
            return View();
        }
    }
}