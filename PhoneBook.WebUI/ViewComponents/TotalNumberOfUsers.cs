using Microsoft.AspNetCore.Mvc;
using PhoneBook.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.WebUI.ViewComponents
{
    /// <summary>
    /// ViewComponent class
    /// </summary>
    public class TotalNumberOfUsers: ViewComponent
    {
        private readonly IPhoneBookRepository repository;

        /// <summary>
        /// constructor with Dependecy Injection
        /// </summary>
        /// <param name="repository"></param>
        public TotalNumberOfUsers(IPhoneBookRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Invoke method
        /// </summary>
        /// <returns>rerturn the count of the users</returns>
        public IViewComponentResult Invoke()
        {
            var count = repository.GetCountOfPhoneUsers();
            return View(count);
        }
    }
}
