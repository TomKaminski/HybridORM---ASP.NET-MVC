namespace MvcEfRepoPatternExample.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Forms", newName: "Form");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Form", newName: "Forms");
        }
    }
}
