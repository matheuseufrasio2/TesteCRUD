using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppTeste.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppTeste.Controllers
{
    public class PersonController : Controller
    {

        private readonly Context.Context _context;
        public PersonController(Context.Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {

            var people = _context.Person;

            return View(people);
        }


        [HttpPost]
        public IActionResult AddNewPerson([FromBody]Person person)
        {
            _context.Person.Add(person);
            _context.SaveChanges();
            return Ok();
        }



        [HttpPost]
        public IActionResult AddNewPerson([FromBody]Person person)
        {
            _context.Person.Add(person);
            _context.SaveChanges();
            return Ok();
        }

    }
}