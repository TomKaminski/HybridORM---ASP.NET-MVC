using System.Data.Entity;
using MvcEfRepoPatternExample.Model.Common;

namespace MvcEfRepoPatternExample.Repository.Common
{
    public class GenericRepository<T> : DapperRepository<T>, IGenericRepository<T> where T : BaseEntity
    {
        protected DbContext Entities;
        protected readonly IDbSet<T> Dbset;

        public GenericRepository(DbContext context)
        {
            Entities = context;
            Dbset = context.Set<T>();
        }

        //public IEnumerable<T> GetAll()
        //{
        //    return Dbset.AsEnumerable();
        //}

        //public T GetSingle(Expression<Func<T, bool>> predicate)
        //{
        //    return Dbset.FirstOrDefault(predicate);
        //}

        //public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        //{
        //    return Dbset.Where(predicate).AsEnumerable();
        //}

        public virtual T Add(T entity)
        {
            return Dbset.Add(entity);
        }

        public virtual T Delete(T entity)
        {
            return Dbset.Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            Entities.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            Entities.SaveChanges();
        }
    }
}
