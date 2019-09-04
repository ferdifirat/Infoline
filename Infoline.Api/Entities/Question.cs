using Infoline.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infoline.Api.Entities
{
    public class Question: IEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
