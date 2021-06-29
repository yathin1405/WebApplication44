namespace WebApplication44.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminFlights",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Airways = c.Int(nullable: false),
                        FROM = c.Int(nullable: false),
                        TO = c.Int(nullable: false),
                        SeatType = c.Int(nullable: false),
                        Departure_Date = c.DateTime(nullable: false),
                        DepartureTime = c.DateTime(nullable: false),
                        Flight_Duration = c.String(),
                        FDelay = c.Boolean(nullable: false),
                        Flight_Delay = c.String(),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Cruises",
                c => new
                    {
                        CruiseID = c.Int(nullable: false, identity: true),
                        ShipName = c.Int(nullable: false),
                        FROM = c.Int(nullable: false),
                        TO = c.Int(nullable: false),
                        Ship_Name = c.String(),
                        Cruise_Duration = c.String(),
                        Num_Guests = c.String(),
                        Departure_Date = c.DateTime(nullable: false),
                        DepartureTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CruiseID);
            
            CreateTable(
                "dbo.Flights",
                c => new
                    {
                        FlightID = c.Int(nullable: false, identity: true),
                        Airways = c.Int(nullable: false),
                        FROM = c.Int(nullable: false),
                        TO = c.Int(nullable: false),
                        SeatType = c.Int(nullable: false),
                        Departure_Date = c.DateTime(nullable: false),
                        DepartureTime = c.DateTime(nullable: false),
                        Return_Flight = c.Boolean(nullable: false),
                        Return_Date = c.DateTime(nullable: false),
                        Return_Time = c.DateTime(nullable: false),
                        Price = c.Single(nullable: false),
                        NumAdults = c.Int(nullable: false),
                        NumAChild = c.Int(nullable: false),
                        Seat_Type_Calc = c.Double(nullable: false),
                        Airline_Fee = c.Double(nullable: false),
                        ReturnTicket_Price = c.Double(nullable: false),
                        passenger_Cost = c.Double(nullable: false),
                        Add_Flight_Delay = c.String(),
                        Available_Seats = c.String(),
                        SEAT = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FlightID);
            
            CreateTable(
                "dbo.Tours",
                c => new
                    {
                        TourId = c.Int(nullable: false, identity: true),
                        Tour_Type = c.Int(nullable: false),
                        Tour_Name = c.String(),
                        Tour_Duration = c.String(),
                        Tour_Date = c.DateTime(nullable: false),
                        Tour_Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TourId);
            
            CreateTable(
                "dbo.UserCruises",
                c => new
                    {
                        CruiseID = c.Int(nullable: false, identity: true),
                        Ship_name = c.Int(nullable: false),
                        FROM = c.Int(nullable: false),
                        TO = c.Int(nullable: false),
                        Ship_Type = c.String(),
                        Cruise_Duration = c.String(),
                        Num_Adults = c.Int(nullable: false),
                        Num_Kids = c.Int(nullable: false),
                        Departure_Date = c.DateTime(nullable: false),
                        Email = c.String(),
                        Ship_Fee = c.Double(nullable: false),
                        Discount = c.Double(nullable: false),
                        Total = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CruiseID);
            
            CreateTable(
                "dbo.UserTours",
                c => new
                    {
                        GuestID = c.Int(nullable: false, identity: true),
                        TourType = c.Int(nullable: false),
                        Num_Adults = c.Int(nullable: false),
                        Num_Kids = c.Int(nullable: false),
                        Email = c.String(),
                        Tour_Name = c.String(),
                        Deposit = c.Double(nullable: false),
                        Discount = c.Double(nullable: false),
                        Total_Tickets = c.Int(nullable: false),
                        Total_Cost = c.Double(nullable: false),
                        GuestCost = c.Double(nullable: false),
                        Tour_Cost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.GuestID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserTours");
            DropTable("dbo.UserCruises");
            DropTable("dbo.Tours");
            DropTable("dbo.Flights");
            DropTable("dbo.Cruises");
            DropTable("dbo.AdminFlights");
        }
    }
}
