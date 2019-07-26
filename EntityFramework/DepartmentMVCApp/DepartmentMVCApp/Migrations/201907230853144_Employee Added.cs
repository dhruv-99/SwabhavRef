namespace DepartmentMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        DateOfJoining = c.String(),
                        Salary = c.Double(nullable: false),
                        Comm = c.Double(nullable: false),
                        Department_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Dpartments", t => t.Department_ID)
                .Index(t => t.Department_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Department_ID", "dbo.Dpartments");
            DropIndex("dbo.Employees", new[] { "Department_ID" });
            DropTable("dbo.Employees");
        }
    }
}
