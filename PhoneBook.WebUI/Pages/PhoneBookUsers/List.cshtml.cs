using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhoneBook.DAL.Data;
using PhoneBook.DAL.Services;

namespace PhoneBook.WebUI.Pages.PhoneBookUsers
{
    /// <summary>
    /// PageModel retrieve all all users
    /// </summary>
    public class ListModel : PageModel
    {
        private readonly IPhoneBookRepository phoneBookRepository;
        /// <summary>
        /// constructor 
        /// Dependecy Injection with constructor injection
        /// </summary>
        /// <param name="phoneBookRepository"></param>
        public ListModel(IPhoneBookRepository phoneBookRepository)
        {
            this.phoneBookRepository = phoneBookRepository;
        }

        public IEnumerable<PhoneUser> PhoneUsers { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchUser { get; set; }

        /// <summary>
        /// search user and order by name
        /// </summary>
        public void OnGet()
        {
            PhoneUsers = phoneBookRepository.GetPhoneUsersByName(SearchUser);
        }
    }
}