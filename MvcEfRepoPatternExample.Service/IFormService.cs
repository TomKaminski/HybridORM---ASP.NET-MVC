using System.Collections.Generic;
using MvcEfRepoPatternExample.Model;
using MvcEfRepoPatternExample.Service.Common;

namespace MvcEfRepoPatternExample.Service
{
    public interface IFormService : IEntityService<Form>
    {
        IEnumerable<Form> GetPagedList(int page, int pageSize);
        int GetCount();
    }
}
