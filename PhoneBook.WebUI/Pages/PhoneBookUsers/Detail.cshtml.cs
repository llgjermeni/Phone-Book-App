using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhoneBook.DAL.Data;
using PhoneBook.DAL.Services;

namespace PhoneBook.WebUI.Pages.PhoneBookUsers
{
    /// <summary>
    /// Page model that retrieve the specific user by id
    /// </summary>
    public class DetailModel : PageModel
    {
        private readonly IPhoneBookRepository repository;

        public PhoneUser PhoneUser { get; set; }

        public DetailModel(IPhoneBookRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Get method 
        /// </summary>
        /// <param name="phoneUserId"></param>
        /// <returns>return the user by id </returns>
        public IActionResult OnGet(int phoneUserId)
        {
            PhoneUser = repository.GetUserById(phoneUserId);
            if (PhoneUser==null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}