// -----------------------------------------------------------------------
// <copyright file="User.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace TestServiceDTOs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Runtime.Serialization;

    [DataContract(Namespace="http://testservicestackservice.com")]
    public class User
    {
        public User() { }

        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
    }
}
