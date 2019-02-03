using PhoneBook.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.DAL.Services
{
    /// <summary>
    /// Interface implemented from the class PhoneBookRepository
    /// </summary>
    public interface IPhoneBookRepository
    {
        List<PhoneUser> GetAllUsers();
        PhoneUser Create(PhoneUser user);
        PhoneUser GetUserById(int id);
        PhoneUser UpdateUser(PhoneUser modofiedEntries);
        IEnumerable<PhoneUser> GetPhoneUsersByName(string name = null);
        int GetCountOfPhoneUsers();
        PhoneUser DeleteUser(int id);
    }
}
