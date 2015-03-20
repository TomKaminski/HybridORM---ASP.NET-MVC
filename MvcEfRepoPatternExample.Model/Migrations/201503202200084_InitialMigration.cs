namespace MvcEfRepoPatternExample.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Forms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(),
                        AuthorLastName = c.String(),
                        CoAuthorName = c.String(),
                        CoAuthorLastName = c.String(),
                        KeeperName = c.String(),
                        KeeperLastName = c.String(),
                        UniversityName = c.String(),
                        UniversityAddress = c.String(),
                        ReportTitle = c.String(),
                        ReportSummary = c.String(),
                        AuthorEmail = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Forms");
        }
    }
}
