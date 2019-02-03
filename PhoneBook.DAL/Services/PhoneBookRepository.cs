using Microsoft.Extensions.Caching.Memory;
using PhoneBook.DAL.Data;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook.DAL.Services
{
    /// <summary>
    /// class implements IPhoneBookRepository interface
    /// </summary>
    public class PhoneBookRepository : IPhoneBookRepository
    {
        private readonly IMemoryCache _cache;
        private readonly List<PhoneUser> phoneUsers;
        public PhoneBookRepository(IMemoryCache cache)
        {
            _cache = cache;
            if (_cache.Get("UserList") == null)
            {
                phoneUsers = new List<PhoneUser>{
                new PhoneUser{Id = 1, FirstName="Anton",LastName="Huan",PhoneType = PhoneType.Cellphone, PhoneNumber="799-95-2345"},
                new PhoneUser{Id = 2, FirstName="Luan",LastName="Hoxha",PhoneType = PhoneType.Home, PhoneNumber="724-34-4763"},
                new PhoneUser{Id = 3, FirstName="Edmond",LastName="Musta",PhoneType = PhoneType.Work, PhoneNumber="834-23-1234"},
                new PhoneUser{Id = 4, FirstName="Orion",LastName="Lila",PhoneType = PhoneType.Home, PhoneNumber="908-34-0987"},
                new PhoneUser{Id = 5, FirstName="Ilir",LastName="Deda",PhoneType = PhoneType.Cellphone, PhoneNumber="879-12-2345"}
            };
                _cache.Set("UserList", phoneUsers);
            }
            
        }

        /// <summary>
        /// Method 
        /// </summary>
        /// <returns>returns all users</returns>
        public List<PhoneUser> GetAllUsers()
        {
            return _cache.Get<List<PhoneUser>>("UserList");
        }

        /// <summary>
        /// method create new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns>return the new user</returns>
        public PhoneUser Create(PhoneUser user)
        {
            phoneUsers.Add(user);
           // user.Id = phoneUsers.Max(c => c.Id) + 1;
            _cache.Set("UserList", phoneUsers);
            return user;
        }

        /// <summary>
        /// method that retrieve user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>return the user by id</returns>
        public PhoneUser GetUserById(int id)
        {
            return phoneUsers.SingleOrDefault(c => c.Id == id);
        }


        /// <summary>
        /// method modifies the user retrieved by id
        /// </summary>
        /// <param name="modifiedPhoneUser"></param>
        /// <returns>return user after modified</returns>
        public PhoneUser UpdateUser(PhoneUser modifiedPhoneUser)
        {
            var user = phoneUsers.SingleOrDefault(c => c.Id == modifiedPhoneUser.Id);
            if (user != null)
            {
                user.FirstName = modifiedPhoneUser.FirstName;
                user.LastName = modifiedPhoneUser.LastName;
                user.PhoneType = modifiedPhoneUser.PhoneType;
                user.PhoneNumber = modifiedPhoneUser.PhoneNumber;
                _cache.Set("UserList", phoneUsers);
            }

            return user;
            
        }

        /// <summary>
        /// method that search for user by name
        /// and oders the list by first name 
        /// </summary>
        /// <param name="name"></param>
        /// <returns>return the user/users</returns>
        public IEnumerable<PhoneUser> GetPhoneUsersByName(string name = null)
        {
            return from p in phoneUsers
                   where string.IsNullOrEmpty(name) || p.FirstName.StartsWith(name)
                   orderby p.FirstName
                   select p;
        }

        /// <summary>
        /// method that delete the user retrieved by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>delete the specific user</returns>
        public PhoneUser DeleteUser(int id)
        {
            var deletedUser = phoneUsers.FirstOrDefault(c => c.Id == id);

            if (deletedUser != null)
            {
                phoneUsers.Remove(deletedUser);
                _cache.Set("UserList", phoneUsers);
            }
            return null;
        }

        /// <summary>
        /// method that count the total number of users
        /// </summary>
        /// <returns>return the number of users</returns>
        public int GetCountOfPhoneUsers()
        {
            return phoneUsers.Count();
        }

       
    }
}
