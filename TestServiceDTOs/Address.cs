// -----------------------------------------------------------------------
// <copyright file="Address.cs" company="Microsoft">
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
    public class Address
    {
        public Address() { }

        [DataMember]
        public string Street { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public string Zip { get; set; }
    }
}
