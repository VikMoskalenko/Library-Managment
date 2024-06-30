using LibraryManagment.classes;
using LibraryManagment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Services
{
    public class UserService
    {
        private readonly IUser _user;
        public UserService(IUser user)
        {

            _user = user;
        }
        public void AddUser(User user)
        {
            _user.AddUser(user);
        }
        public void UpdateUser(User user)
        {
            _user.UpdateUser(user);
        }
        public void DeleteUser(int id)
        {
            _user.DeleteUser(id);
        }
        public User GetUserById(int id)
        {
            return _user.GetUserById(id);
        }
        public List<User> GetAllUsers()
        {
            return _user.GetAllUsers();
        }
    }
}
