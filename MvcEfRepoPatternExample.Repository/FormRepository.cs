using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MvcEfRepoPatternExample.Model;
using MvcEfRepoPatternExample.Repository.Common;

namespace MvcEfRepoPatternExample.Repository
{
    class FormRepository:GenericRepository<Form>,IFormRepository
    {
        public FormRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Form> GetPagedList(int page, int pageSize)
        {
            return GetAll().Skip(page*pageSize-pageSize).Take(pageSize);
        }

        public int GetCount()
        {
            return GetAll().Count();
        }        
    }
}
