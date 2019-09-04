using Infoline.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infoline.Api.Business.Abstract
{
    public interface IUsersAnswerService
    {
        bool AddUserAnswer(UserQuestionViewModel model);
        UsersAnswersViewModel GetAnswers();
    }
}
