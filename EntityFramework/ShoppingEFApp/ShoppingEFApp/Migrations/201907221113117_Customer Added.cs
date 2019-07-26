namespace ShoppingEFApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        CustomerName = c.String(),
                        CustomerAddress = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.ORDER", "Customer_ID", c => c.Guid());
            CreateIndex("dbo.ORDER", "Customer_ID");
            AddForeignKey("dbo.ORDER", "Customer_ID", "dbo.Customers", "ID");
            DropColumn("dbo.ORDER", "CustomerName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ORDER", "CustomerName", c => c.String());
            DropForeignKey("dbo.ORDER", "Customer_ID", "dbo.Customers");
            DropIndex("dbo.ORDER", new[] { "Customer_ID" });
            DropColumn("dbo.ORDER", "Customer_ID");
            DropTable("dbo.Customers");
        }
    }
}
