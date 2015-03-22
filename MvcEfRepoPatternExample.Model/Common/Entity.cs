namespace MvcEfRepoPatternExample.Model.Common
{
    public abstract class Entity<T>:IEntity<T>
    {
        public virtual T Id { get; set; }
    }
}
