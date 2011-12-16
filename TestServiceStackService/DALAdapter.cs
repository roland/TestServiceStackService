using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestServiceStackService
{
    public static class DALAdapter
    {
        public static TestServiceDTOs.User Convert(TestServiceDAL.User user)
        {
            if (user == null)
                return null;

            var dtoUser = new TestServiceDTOs.User()
            {
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
            };

            if (user.Address != null)
            {
                dtoUser.Address = new TestServiceDTOs.Address()
                {
                    City = user.Address.City,
                    State = user.Address.State,
                    Street = user.Address.Street,
                    Zip = user.Address.Zip
                };
            }

            return dtoUser;
        }
    }
}