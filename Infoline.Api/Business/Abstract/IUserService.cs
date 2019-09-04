using Infoline.Api.Dto;
using Infoline.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infoline.Api.Business.Abstract
{
    public interface IUserService
    {
        UserInfoViewModel GetRandomUsers();
        UserInfoViewModel GetUsers();
        bool DeleteUser(int id);
        bool AddUsers(List<UserDto> userInfoViewModel);
        List<UserSummaryDto> GetUsersSummary();
    }
}
