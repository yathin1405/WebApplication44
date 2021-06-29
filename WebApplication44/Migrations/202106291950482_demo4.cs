namespace WebApplication44.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class demo4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AdminFlights", "DepartureTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AdminFlights", "DepartureTime", c => c.String());
        }
    }
}
