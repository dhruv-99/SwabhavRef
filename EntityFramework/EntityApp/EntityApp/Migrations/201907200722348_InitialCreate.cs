namespace EntityApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.STUDENT",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        NAME = c.String(),
                        CGPI = c.Single(nullable: false),
                        LOC = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.STUDENT");
        }
    }
}
