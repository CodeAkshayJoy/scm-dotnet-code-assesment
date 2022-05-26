using System;
using System.Collections.Generic;
using System.Text;

namespace UserService.Console.Exceptions
{
    public class DuplicateUserException : Exception
    {
        public DuplicateUserException()
            : base("DuplicateUserException occurred.")
        {
            ErrorMessage = "DuplicateUserException occurred.";
        }

        public DuplicateUserException(string errorMessage)
            : this()
        {
            ErrorMessage=errorMessage;
        }

        public String ErrorMessage { get; set; }
    }
}
