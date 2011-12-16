using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ServiceStack.ServiceClient.Web;
using TestServiceDTOs.Responses;
using TestServiceDTOs.Requests;

namespace TestServiceStackService.Tests
{
    [TestFixture]
    public class AuthenticateTests
    {
        [Test]
        public void T00_Test_authenticate_with_user1_json()
        {
            var restClient = new JsonServiceClient("http://localhost:25000/json/asynconeway/AuthenticateRequest");
            var response = restClient.Send<AuthenticateResponse>(
                new AuthenticateRequest()
                {
                    Username = "user1",
                    Password = "password"
                }
            );

            
        }

        [Test]
        public void T01_Test_authenticate_with_user1_xml()
        {
        }
    }
}
