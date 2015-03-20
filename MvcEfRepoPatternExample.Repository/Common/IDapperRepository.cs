using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using MvcEfRepoPatternExample.Model.Common;

namespace MvcEfRepoPatternExample.Repository.Common
{
    public interface IDapperRepository<T> where T : BaseEntity
    {
        IDbConnection Connection { get; }
        T FindById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Func<T, bool> predicate);
    }
}
