using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.ServiceHost;
using TestServiceDTOs.Requests;
using TestServiceDTOs.Responses;

namespace TestServiceStackService
{
    public class AuthenticateService : IService<AuthenticateRequest>
    {
        public object Execute(AuthenticateRequest request)
        {
            AuthenticateResponse response;
            try
            {
                var user = DALAdapter.Convert(TestServiceDAL.User.Authenticate(request.Username, request.Password));
                response = new AuthenticateResponse()
                {
                    User = user,
                    Success = true,
                    Message = "Authentication Succeeded"
                };
            }
            catch (Exception ex)
            {
                response = new AuthenticateResponse()
                {
                    Success = false,
                    Message = ex.Message
                };
            }

            return response;
        }
    }
}