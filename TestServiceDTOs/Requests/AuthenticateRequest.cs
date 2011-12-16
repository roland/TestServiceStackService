// -----------------------------------------------------------------------
// <copyright file="AuthenticateMe.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace TestServiceDTOs.Requests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Runtime.Serialization;

    [DataContract(Namespace="http://testservicestackservice.com")]
    public class AuthenticateRequest
    {
        public AuthenticateRequest() { }

        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }
    }
}
