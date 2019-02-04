using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PhoneBook.DAL.Data;
using PhoneBook.DAL.Services;

namespace PhoneBook.WebUI.Pages.PhoneBookUsers
{
    /// <summary>
    /// PageModel edit and save users
    /// with two method get and post 
    /// </summary>
    public class EditModel : PageModel
    {
        private readonly IPhoneBookRepository repository;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public PhoneUser PhoneUser { get; set; }
        public IEnumerable<SelectListItem> PhoneType { get; set; }

        /// <summary>
        /// Dependecy Injection with constructor injection
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="htmlHelper"></param>
        public EditModel(IPhoneBookRepository repository, IHtmlHelper htmlHelper)
        {
            this.repository = repository;
            this.htmlHelper = htmlHelper;
        }

        /// <summary>
        /// 
        /// if id not found return the page not found
        /// </summary>
        /// <param name="userId"></param>
        /// <returns> retrieve the user by id</returns>
        public IActionResult OnGet(int? userId)
        {
            PhoneType = htmlHelper.GetEnumSelectList<PhoneType>();
            if (userId.HasValue)
            {
                PhoneUser = repository.GetUserById(userId.Value);
            }
            else
            {
                PhoneUser = new PhoneUser();
            }
            if (PhoneUser==null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
          
        }

        /// <summary>
        ///      Method post that edit the user
        /// </summary>
        /// <returns>return the user after modified</returns>
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                PhoneType = htmlHelper.GetEnumSelectList<PhoneType>();
                return Page();
            }
            if (PhoneUser.Id>0)
            {
                repository.UpdateUser(PhoneUser);
            }
            else
            {
                repository.Create(PhoneUser);
            }

            TempData["Message"] = "Entries saved";
            return RedirectToPage("./Detail", new { phoneUserId = PhoneUser.Id });
        }
    }
}