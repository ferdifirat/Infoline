using Infoline.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infoline.Api.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public int PostCode { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Cell { get; set; }
        public string Gender { get; set; }

        public virtual List<UsersAnswer> UserAnswers { get; set; }
    }
}
