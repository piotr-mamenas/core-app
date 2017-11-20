using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace eCorp.KeyTrade.Core.Domain.Interfaces
{
    public interface IRepository<T> : IQueryable<T> where T : IEntity
    {
        T GetById(string id);

        T Add(T entity);
        void Add(IEnumerable<T> entities);

        T Update(T entity);
        void Update(IEnumerable<T> entities);

        void Delete(string id);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> predicate);
        void DeleteAll();

        long Count();
        bool Exists(Expression<Func<T, bool>> predicate);

        IDisposable RequestStart();

        void RequestDone();
    }
}