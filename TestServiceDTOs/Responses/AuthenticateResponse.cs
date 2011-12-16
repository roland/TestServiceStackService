// -----------------------------------------------------------------------
// <copyright file="AuthenticateResponse.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace TestServiceDTOs.Responses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Runtime.Serialization;

    [DataContract(Namespace="http://testservicestackservice.com")]
    public class AuthenticateResponse
    {
        public AuthenticateResponse() { }

        [DataMember]
        public User User { get; set; }
        [DataMember]
        public bool Success { get; set; }
        [DataMember]
        public string Message { get; set; }
    }
}
