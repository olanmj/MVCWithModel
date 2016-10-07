using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWithModel.Models;

namespace MVCWithModel.Controllers
{
    public class HomeController : Controller
    {
        // CharacterRepo replaced by a database
      //  static CharacterRepo characters = new CharacterRepo();
        public IActionResult Index()
        {
            ViewData["Title"] = "Home";
            return View();
        }

        // These are no longer used.
        // CharacterRepo is replace by a database

        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Create(Character newCharacter)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        characters.CharacterList.Add(newCharacter);
        //        return RedirectToAction("Index");
        //    }
        //    return View(newCharacter);
        //}

        public IActionResult About()
        {
            ViewData["Message"] = "The Character Application.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Anonymous...";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
