using System.Reflection;
using Autofac;
using Module = Autofac.Module;

namespace MvcEfRepoPatternExample.Modules
{
    public class RepositoryModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load("MvcEfRepoPatternExample.Repository"))
                   .Where(t => t.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces()
                  .InstancePerLifetimeScope();
        }
    }
}