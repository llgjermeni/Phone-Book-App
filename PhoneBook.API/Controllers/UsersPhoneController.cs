using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.DAL.Data;
using PhoneBook.DAL.Services;


namespace PhoneBook.API.Controllers
{
    /// <summary>
    /// Web API controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UsersPhoneController : Controller
    {
        private readonly IPhoneBookRepository repository;

        public UsersPhoneController(IPhoneBookRepository repository)
        {
            this.repository = repository;
        }
        /// <summary>
        /// Action method GET: api/
        /// return all users
        /// </summary>
        [HttpGet]
        public IEnumerable<PhoneUser> Get()
        {
            return repository.GetAllUsers();
        }

        /// <summary>
        ///   GET method return users by id 
        ///   api/<controller>/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public PhoneUser Get(int id)
        {
            return repository.GetUserById(id);
        }

        /// <summary>
        /// <param name="phoneUser"></param>
        // POST method create new user
        ///  api/<controller>
        /// </summary>
        [HttpPost]
        public void Post([FromBody]PhoneUser phoneUser)
        {
               repository.Create(phoneUser);
        }

         /// <summary>
         ///  Put method update user
         /// </summary>
         /// <param name="id"></param>
         /// <param name="phoneUser"></param>
        /// PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]PhoneUser phoneUser)
        {
            repository.UpdateUser(phoneUser);
        }

        /// <summary>
        /// Delete method delete a user with the called id
        /// </summary>
        /// <param name="id"></param>
        /// DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.DeleteUser(id);
        }
    }
}
