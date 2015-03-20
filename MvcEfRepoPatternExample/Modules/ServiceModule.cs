using System.Reflection;
using Autofac;
using Module = Autofac.Module;

namespace MvcEfRepoPatternExample.Modules
{
    public class ServiceModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load("MvcEfRepoPatternExample.Service"))
                      .Where(t => t.Name.EndsWith("Service"))
                      .AsImplementedInterfaces()
                      .InstancePerLifetimeScope();

        }
    }
}