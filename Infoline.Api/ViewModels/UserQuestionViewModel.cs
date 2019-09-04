using Infoline.Api.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infoline.Api.ViewModels
{
    public class UserQuestionViewModel
    {
        public List<UserSummaryDto> Users{ get; set; }
        public UserSummaryDto User { get; set; }
        public QuestionDto QuestionDto { get; set; }
    }
}
