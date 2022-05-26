using System;
using System.Collections.Generic;
using System.Text;
using UserService.Console.Domain;
using UserService.Console.Repository.Interfaces;

namespace UserService.Console.Repository
{
    /// <summary>
    /// Q: Implement a method that allows you to get all the users over a certain age
    //  Q: Implement a method that removes a User from the repository - based on name.
    //  why did I use List - as the type of the list of users, and not an implementation of List?
    /// </summary
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users;
        public UserRepository()
        {
            _users= new List<User>();
        }
        public void AddNewUser(User user)
        {
            throw new NotImplementedException();
        }

        public void AddNewUserWith(string userName, int userAge)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public List<User> GetAllUsersWithName(string name)
        {
            return null;
        }
    }
}
