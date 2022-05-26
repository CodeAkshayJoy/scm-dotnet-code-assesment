using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserService.Console.Domain;
using UserService.Console.Exceptions;
using UserService.Console.Repository;

namespace UserService.Tests
{
    public class UserRepositoryTest
    {

        private UserRepository repository;
        [SetUp]
        public void Setup()
        {
            repository = new UserRepository();
        }
        public void init()
        {
            repository = new UserRepository();
        }

        [Test]
        public void addingANewUserToTheRepositoryWillPersistIt()
        {
            User newUser = new User("Claudia", 42);
            repository.AddNewUser(newUser);
            List<User> users = repository.GetAllUsers();
            Assert.True(users.Count==1, "The size or repo is 1");
            Assert.True(newUser.Equals(users.FirstOrDefault()), "the user matches");
        }

        [Test]
        public void addingNewUserUsingTheFieldsWillPersistIt()
        {
            //Q: add a test that will check if you add a user with the individual fields that it adds it to the repository.
            //repository.AddNewUserWith(name, age);
        }

        [Test]
        public void adding2usersWithSameNameAndAgeWillThrowDuplicateUserException()
        {
            Assert.Throws<DuplicateUserException>(
                () =>
                {
                    User newUser = new User("Claudia", 42);
                    repository.AddNewUser(newUser);
                    repository.AddNewUser(newUser);
                    //Q: what other data structure you would use, in the UserRepository, in order to avoid having to work hard for deduplicating
                    //Q: is it a good idea or not to through an exception for a duplicate?

                });

        }

        [Test]
        public void addingAUserWithEmptyOrNullNameWillThrowIllegalArgumentException()
        {
            Assert.Throws<ArgumentException>(
            () =>
            {
                User theUser = new User("", 11);
                User theNullUser = new User(null, 12);
                repository.AddNewUser(theUser);
                repository.AddNewUser(theNullUser);
                //Q: where is a better place to have this validation??

            });

        }

        //Q: what is the difference between the DuplicateUserException and IllegalArgumentException?
        [Test]
        public void addingMultipleUsersToRepositoryAndReturningAllUsersWithName()
        {
            String theName = "Claudia";
            User newUser = new User("Claudia", 42);
            User newUser2 = new User("Claudia", 32);
            User newUser3 = new User("Claudia", 26);
            User newUser4 = new User("Johan", 26);
            repository.AddNewUser(newUser);
            repository.AddNewUser(newUser2);
            repository.AddNewUser(newUser3);
            repository.AddNewUser(newUser4);
            List<User> users = repository.GetAllUsersWithName(theName);
            Assert.True(users.Count == 3, "The size or repo is 3");
            Assert.True(newUser.Equals(users[0]), "the user1 matches");
            Assert.True(newUser2.Equals(users[1]), "the user2 matches");
            Assert.True(newUser3.Equals(users[2]), "the user3 matches");

            //Q : how would you refactor your code - to eliminate the need for calling repository.addnewUser multiple times?
        }
    }
}
