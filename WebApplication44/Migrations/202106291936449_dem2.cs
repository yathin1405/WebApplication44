namespace WebApplication44.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dem2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AdminFlights", "Departure_Date", c => c.Int(nullable: false));
            AlterColumn("dbo.AdminFlights", "DepartureTime", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AdminFlights", "DepartureTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AdminFlights", "Departure_Date", c => c.String());
        }
    }
}
