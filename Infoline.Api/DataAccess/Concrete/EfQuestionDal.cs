using Infoline.Api.Core.EntityFramework;
using Infoline.Api.DataAccess.Abstract;
using Infoline.Api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infoline.Api.DataAccess.Concrete
{
    public class EfQuestionDal : EfRepositoryBase<Question>, IQuestionDal
    {
        public EfQuestionDal(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
