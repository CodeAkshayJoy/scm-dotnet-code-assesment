using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace UserService.Console.Domain
{
    public class User : IComparable,IEquatable<User>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string _name, int _age)
        {
            Name = _name;
            Age = _age;
        }

        public override int GetHashCode()=>
            HashCode.Combine(Name, Age);



        public bool Equals(User other)
        {
            return ((Name == other.Name) && (Age == other.Age));
        }

        public override string ToString()
        {
            return string.Join(";", Name, Age);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is User))
            {
                throw new ArgumentException("Compared Object is not of User");
            }
            User user = obj as User;
            return Name.CompareTo(user.Name);
        }
    }
}
