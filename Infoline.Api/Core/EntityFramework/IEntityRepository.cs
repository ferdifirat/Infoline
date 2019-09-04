using Infoline.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infoline.Api.Core.EntityFramework
{
    public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        List<T> GetList(Expression<Func<T, bool>> condition = null);
        T Get(Expression<Func<T, bool>> condition);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
        bool SaveChanges();

    }
}
