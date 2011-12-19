using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestServiceDAL
{
    public class User
    {
        public User() { }

        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        /// <summary>
        /// Simple fake user authentication example, with a complex address property
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static User Authenticate(string username, string password)
        {
            switch (username)
            {
                case "user1":
                    return new User()
                    {
                        Username = username,
                        FirstName = "First Name"
                    };
                case "user2":
                    return new User()
                    {
                        Username = username,
                        LastName = "Last Name"
                    };
                case "user3":
                    return new User()
                    {
                        Username = username,
                        FirstName = "First Name",
                        Address = new Address() { City = "New York" }
                    };
                default:
                    return new User()
                    {
                        Username = username,
                        FirstName = "First Name",
                        LastName = "Last Name",
                        Address = new Address() { 
                            City = "New York",
                            State = "NY",
                            Street = "123 Main St",
                            Zip = "00001"
                        }
                    };
            }
        }
    }
}
