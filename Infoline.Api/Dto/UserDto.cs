using Infoline.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infoline.Api.Dto
{
    public class UserDto
    {
        public int    Id { get; set; }
        public string first { get; set; }
        public string last { get; set; }
        public string city { get; set; }
        public int    postcode { get; set; }
        public string username { get; set; }
        public int    age { get; set; }
        public string email { get; set; }
        public string cell { get; set; }
        public string gender { get; set; }


        public UserDto Map(User u)
        {
            Id = u.Id;
            first = u.FirstName;
            last = u.LastName;
            city = u.City;
            postcode = u.PostCode;
            username = u.UserName;
            age = u.Age;
            email = u.Email;
            cell = u.Cell;
            gender = u.Gender;

            return this;
        }
    }
}
