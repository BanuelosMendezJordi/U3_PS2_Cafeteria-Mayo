namespace U3_PS2_Cafeteria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracion_12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Status");
        }
    }
}
