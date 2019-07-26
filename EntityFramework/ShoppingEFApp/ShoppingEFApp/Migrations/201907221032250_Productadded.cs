namespace ShoppingEFApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Productadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ProductName = c.String(),
                        ProductCost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.LINEITEM", "product_ID", c => c.Guid());
            CreateIndex("dbo.LINEITEM", "product_ID");
            AddForeignKey("dbo.LINEITEM", "product_ID", "dbo.Products", "ID");
            DropColumn("dbo.LINEITEM", "ProductName");
            DropColumn("dbo.LINEITEM", "UnitPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LINEITEM", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("dbo.LINEITEM", "ProductName", c => c.String());
            DropForeignKey("dbo.LINEITEM", "product_ID", "dbo.Products");
            DropIndex("dbo.LINEITEM", new[] { "product_ID" });
            DropColumn("dbo.LINEITEM", "product_ID");
            DropTable("dbo.Products");
        }
    }
}
