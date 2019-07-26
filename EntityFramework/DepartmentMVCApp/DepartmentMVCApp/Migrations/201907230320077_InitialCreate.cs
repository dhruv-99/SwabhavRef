namespace DepartmentMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dpartments",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        DeptName = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Dpartments");
        }
    }
}
