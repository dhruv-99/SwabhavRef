namespace EntityApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ageforstudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.STUDENT", "AGE", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.STUDENT", "AGE");
        }
    }
}
