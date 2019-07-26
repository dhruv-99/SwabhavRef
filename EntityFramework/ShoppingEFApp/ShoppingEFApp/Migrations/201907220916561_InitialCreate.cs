namespace ShoppingEFApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LINEITEM",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ProductName = c.String(),
                        UnitPrice = c.Double(nullable: false),
                        order_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ORDER", t => t.order_ID)
                .Index(t => t.order_ID);
            
            CreateTable(
                "dbo.ORDER",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Date = c.String(),
                        CustomerName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LINEITEM", "order_ID", "dbo.ORDER");
            DropIndex("dbo.LINEITEM", new[] { "order_ID" });
            DropTable("dbo.ORDER");
            DropTable("dbo.LINEITEM");
        }
    }
}
