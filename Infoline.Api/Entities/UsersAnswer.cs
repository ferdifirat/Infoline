using Infoline.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infoline.Api.Entities
{
    public class UsersAnswer : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public string Answer { get; set; }
        public DateTime AnswerDate { get; set; }

        public virtual User User { get; set; }
        public virtual Question Question { get; set; }
    }
}