using Infoline.Api.Business.Abstract;
using Infoline.Api.DataAccess.Abstract;
using Infoline.Api.Dto;
using Infoline.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infoline.Api.Business.Concrete
{
    public class QuestionManager:IQuestionService
    {
        private readonly IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

        public QuestionDto GetRandomQuestion()
        {

            var questions = _questionDal.GetList();

            Random random = new Random();
            int randomQuestionId = random.Next(1, questions.Count());

            var randomQuestion = questions.SingleOrDefault(p => p.Id == randomQuestionId);

            var result = new QuestionDto()
            {
                Id = randomQuestion.Id,
                Text = randomQuestion.Text
            };
            

            return result;
        }
    }
}
