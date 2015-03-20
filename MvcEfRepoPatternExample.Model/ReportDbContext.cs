using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MvcEfRepoPatternExample.Model
{
    public class ReportDbContext:DbContext
    {
        public ReportDbContext():base("ReportDbContext")
        {            
        }

        public DbSet<Form> Form { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public class ReportDbContextInitializer : DropCreateDatabaseIfModelChanges<ReportDbContext>
        {
            protected override void Seed(ReportDbContext context)
            {
                base.Seed(context);
            }
        }
    }
}
