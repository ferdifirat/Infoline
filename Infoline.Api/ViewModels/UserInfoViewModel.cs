using Infoline.Api.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infoline.Api.ViewModels
{
    public class UserInfoViewModel
    {
        public List<UserDto> Users { get; set; }
        public UserDto User { get; set; }
        public List<UserDto> AddedUsers { get; set; }
    }
}
