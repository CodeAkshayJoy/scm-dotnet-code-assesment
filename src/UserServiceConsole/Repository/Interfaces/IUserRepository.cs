using System;
using System.Collections.Generic;
using System.Text;
using UserService.Console.Domain;

namespace UserService.Console.Repository.Interfaces
{
    /// <summary>
    /// Q: Implement a method that allows you to get all the users over a certain age
    //  Q: Implement a method that removes a User from the repository - based on name.
    //  why did I use List - as the type of the list of users, and not an implementation of List?
    /// </summary>
    public interface IUserRepository
    {
        void AddNewUser(User user);
        void AddNewUserWith(string userName, int userAge);
        List<User> GetAllUsers();
        List<User> GetAllUsersWithName(String name);
    }
}
