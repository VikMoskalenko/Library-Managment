using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Interfaces
{
    public interface IUser
    {
        void AddUser(User user);
        void UpdateUser (User user);
        void DeleteUser (int id);
        User GetUserById (int id);
        List<User> GetAllUsers ();
    }
}
