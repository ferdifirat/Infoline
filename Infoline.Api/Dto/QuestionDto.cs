using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infoline.Api.Dto
{
    public class QuestionDto
    {
        [HiddenInput]
        public int Id { get; set; }
        public string Text { get; set; }
        public string Answer { get; set; }

    }
}
