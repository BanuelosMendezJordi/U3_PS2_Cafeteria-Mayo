namespace U3_PS2_Cafeteria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracion_Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        ClientName = c.String(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        ProductId = c.Int(nullable: false),
                        OrderQuantity = c.Int(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductCode = c.String(nullable: false),
                        ProductName = c.String(nullable: false),
                        ProductDescription = c.String(nullable: false),
                        ProductType = c.String(nullable: false),
                        ProductPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductImage = c.Binary(),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ProductId", "dbo.Products");
            DropIndex("dbo.Orders", new[] { "ProductId" });
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
        }
    }
}
