using System.Collections.Generic;
using MvcEfRepoPatternExample.Model;
using MvcEfRepoPatternExample.Repository.Common;

namespace MvcEfRepoPatternExample.Repository
{
    public interface IFormRepository:IGenericRepository<Form>,IDapperRepository<Form>
    {
        IEnumerable<Form> GetPagedList(int page, int pageSize);
        int GetCount();
    }
}
