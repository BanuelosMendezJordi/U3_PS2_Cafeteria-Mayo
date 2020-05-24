namespace U3_PS2_Cafeteria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracion_11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderCode", c => c.String(nullable: false));
            DropColumn("dbo.Orders", "OrderName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "OrderName", c => c.String(nullable: false));
            DropColumn("dbo.Orders", "OrderCode");
        }
    }
}
