using Infoline.Api.Core.EntityFramework;
using Infoline.Api.Entities;
using Infoline.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infoline.Api.DataAccess.Abstract
{
    public interface IUsersAnswerDal : IEntityRepository<UsersAnswer>
    {
        UsersAnswersViewModel GetAnswersWithDetails();
    }
}
