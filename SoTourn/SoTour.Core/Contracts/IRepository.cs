using System;
using System.Linq;
using System.Linq.Expressions;

namespace SoTour.Core.Contracts
{
    public interface IRepository<T>
    {
        //void Insert(T entity);
        //void Delete(T entity);
        //IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        //T GetById(int id);
    }
}