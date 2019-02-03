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
    /// Page Model delete a user by id
    /// </summary>
    public class DeleteModel : PageModel
    {
        private readonly IPhoneBookRepository repository;

        public PhoneUser PhoneUser { get; set; }

        public DeleteModel(IPhoneBookRepository repository)
        {
            this.repository = repository;
        }
                
        /// <summary>
        /// Get method 
        /// </summary>
        /// <param name="phoneUserId"></param>
        /// <returns>return the user by id</returns>
        public IActionResult OnGet(int phoneUserId)
        {
            PhoneUser = repository.GetUserById(phoneUserId);

            if (PhoneUser == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();

        }

        /// <summary>
        /// Post method
        /// </summary>
        /// <param name="phoneUserId"></param>
        /// <returns>return all users deleted the specific user</returns>
        public IActionResult OnPost(int phoneUserId)
        {
            var phoneUser = repository.DeleteUser(phoneUserId);

            if (phoneUser==null)
            {
                return RedirectToPage("./NotFound");
            }

            TempData["Message"] = $"{phoneUser.FirstName} is deleted";
            return RedirectToPage("./List");
        }
    }
}


    