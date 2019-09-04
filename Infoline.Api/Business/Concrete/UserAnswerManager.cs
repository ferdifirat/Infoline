using Infoline.Api.Business.Abstract;
using Infoline.Api.DataAccess.Abstract;
using Infoline.Api.Entities;
using Infoline.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infoline.Api.Business.Concrete
{
    public class UserAnswerManager : IUsersAnswerService
    {
        private readonly IUsersAnswerDal _usersAnswerDal;

        public UserAnswerManager(IUsersAnswerDal usersAnswerDal)
        {
            _usersAnswerDal = usersAnswerDal;
        }

        public bool AddUserAnswer(UserQuestionViewModel model)
        {
            var usersAnswer = new UsersAnswer()
            {
                AnswerDate = DateTime.UtcNow,
                QuestionId = model.QuestionDto.Id,
                UserId = model.User.Id,
                Answer = model.QuestionDto.Answer
            };

            _usersAnswerDal.Add(usersAnswer);
            return _usersAnswerDal.SaveChanges();

        }

        public UsersAnswersViewModel GetAnswers()
        {
            return _usersAnswerDal.GetAnswersWithDetails();
        }
    }
}
