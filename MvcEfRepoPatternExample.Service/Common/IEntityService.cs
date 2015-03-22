using System.Collections.Generic;
using MvcEfRepoPatternExample.Model.Common;

namespace MvcEfRepoPatternExample.Service.Common
{
    public interface IEntityService<T>
     where T : class
    {
        void Create(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        void Update(T entity);
    }
}
