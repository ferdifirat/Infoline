using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infoline.Api.Dto
{
    public class UsersAnswersDto
    {
        public string UserName { get; set; }
        public int UserId { get; set; }
        public DateTime AnswerDate { get; set; }
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string AnswerText { get; set; }

    }
}
