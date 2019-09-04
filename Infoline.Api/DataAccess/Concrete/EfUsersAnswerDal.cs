using Infoline.Api.Core.EntityFramework;
using Infoline.Api.DataAccess.Abstract;
using Infoline.Api.Dto;
using Infoline.Api.Entities;
using Infoline.Api.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infoline.Api.DataAccess.Concrete
{
    public class EfUsersAnswerDal : EfRepositoryBase<UsersAnswer>, IUsersAnswerDal
    {
        public EfUsersAnswerDal(DbContext dbContext) : base(dbContext)
        {

        }

        public UsersAnswersViewModel GetAnswersWithDetails()
        {
            var result = new UsersAnswersViewModel();
            using (var context = new Context())
            {
                result.UsersAnswers = context.UserAnswers
                                             .Include(x => x.User)
                                             .Include(x => x.Question)
                                             .Select(item => new UsersAnswersDto
                                             {
                                                 AnswerDate = item.AnswerDate,
                                                 QuestionId = item.QuestionId,
                                                 QuestionText = item.Question.Text,
                                                 UserId = item.UserId,
                                                 UserName = item.User.UserName,
                                                 AnswerText = item.Answer
                                             })
                                             .ToList();
            }

            return result;
        }
    }
}
