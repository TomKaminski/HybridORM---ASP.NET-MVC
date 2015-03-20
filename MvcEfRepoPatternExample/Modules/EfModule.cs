using System.Data.Entity;
using Autofac;
using MvcEfRepoPatternExample.Repository.Common;
using MvcEfRepoPatternExample.Model;

namespace MvcEfRepoPatternExample.Modules
{
    public class EfModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositoryModule());
            builder.RegisterType(typeof(ReportDbContext)).As(typeof(DbContext)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();
        }
    }
}