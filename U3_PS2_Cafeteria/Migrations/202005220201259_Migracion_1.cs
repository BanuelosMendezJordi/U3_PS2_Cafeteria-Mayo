namespace U3_PS2_Cafeteria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracion_1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderName", c => c.String(nullable: false));
            AddColumn("dbo.Orders", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Orders", "OrderDate");
            DropColumn("dbo.Orders", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Status", c => c.String());
            AddColumn("dbo.Orders", "OrderDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Orders", "Total");
            DropColumn("dbo.Orders", "OrderName");
        }
    }
}
