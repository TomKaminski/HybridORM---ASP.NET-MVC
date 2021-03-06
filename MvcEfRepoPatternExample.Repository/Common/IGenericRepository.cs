﻿using MvcEfRepoPatternExample.Model.Common;

namespace MvcEfRepoPatternExample.Repository.Common
{
    public interface IGenericRepository<T> : IDapperRepository<T> where T : class
    {
        //IEnumerable<T> GetAll();
        //T GetSingle(Expression<Func<T, bool>> predicate);
        //IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        T Add(T entity);
        T Delete(T entity);
        void Edit(T entity);
        void Save();
    }
}
