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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public int    PostCode { get; set; }
        public string UserName { get; set; }
        public int    Age { get; set; }
        public string Email { get; set; }
        public string Cell { get; set; }
        public string Gender { get; set; }


        public UserDto Map(User u)
        {
            Id = u.Id;
            FirstName = u.FirstName;
            LastName = u.LastName;
            City = u.City;
            PostCode = u.PostCode;
            UserName = u.UserName;
            Age = u.Age;
            Email = u.Email;
            Cell = u.Cell;
            Gender = u.Gender;

            return this;
        }
    }
}
