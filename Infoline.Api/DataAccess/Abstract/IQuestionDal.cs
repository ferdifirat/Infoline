using Infoline.Api.Core.EntityFramework;
using Infoline.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infoline.Api.DataAccess.Abstract
{
    public interface IQuestionDal : IEntityRepository<Question>
    {
    }
}
