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
        static CharacterRepo characters = new CharacterRepo();
        public IActionResult Index()
        {
            ViewData["Title"] = "Home";
            //Character person = new Character() { Name = "Some Name" };
            //characters.CharacterList.Add(person);
            //person = new Character() { Name = "Another Name" };
            //characters.CharacterList.Add(person);
            return View(characters);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Character newCharacter)
        {
            characters.CharacterList.Add(newCharacter);
            return RedirectToAction("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
