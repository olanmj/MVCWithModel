using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWithModel.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCWithModel.Controllers
{
    public class CharacterController : Controller
    {
        private readonly CharacterContext _context;

        public CharacterController(CharacterContext c)
        {
            _context = c;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = _context.Characters.OrderBy(c => c.Name).ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Character character)
        {
            if (ModelState.IsValid)
            {
                _context.Characters.Add(character);
                _context.SaveChanges();
                return RedirectToAction("Index"); 
            }
            return View(character);
        }
    }
}
