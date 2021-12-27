using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Starx.Models;
using Strax.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starx.Areas.admin.Controllers
{
    [Area("admin")]
    public class ServisCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public ServisCategoryController(AppDbContext context)
        {
           _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category model)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_context.Categories.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Category model)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Category category = _context.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            bool IsRelation = _context.Servis.Any(c => c.CategoryId == category.Id);

            if (IsRelation)
            {
                HttpContext.Session.SetString("CategoryError", "There is some blog related to the category!");
            }
            else
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }


            return RedirectToAction("Index");
        }
    }
}
