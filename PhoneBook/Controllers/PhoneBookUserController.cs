using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.DAL.Data;
using PhoneBook.DAL.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhoneBook.Controllers
{
    public class PhoneBookUserController : Controller
    {
        private readonly IPhoneBookRepository Repository;

        public PhoneBookUserController(IPhoneBookRepository repository)
        {
            Repository = repository;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = Repository.GetAllUsers();
            return View(model);
        }

        public IActionResult Details(int id)
        {                                     
            var model = Repository.GetUserById(id);

            if (model==null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(PhoneUser user)
        {
            if (ModelState.IsValid)
            {
                var newUser = new PhoneUser();
                return Repository.Create(newUser);
            }
        }
    }
}
