using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication44.Data
{
    public class WebApplication44Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebApplication44Context() : base("name=WebApplication44Context")
        {
        }

        public System.Data.Entity.DbSet<WebApplication44.Models.Flight> Flights { get; set; }

        public System.Data.Entity.DbSet<WebApplication44.Models.AdminFlight> AdminFlights { get; set; }

        public System.Data.Entity.DbSet<WebApplication44.Models.Cruise> Cruises { get; set; }

        public System.Data.Entity.DbSet<WebApplication44.Models.UserCruise> UserCruises { get; set; }

        public System.Data.Entity.DbSet<WebApplication44.Models.Tour> Tours { get; set; }

        public System.Data.Entity.DbSet<WebApplication44.Models.UserTour> UserTours { get; set; }

        public System.Data.Entity.DbSet<WebApplication44.Models.UserQuote> UserQuotes { get; set; }
    }
}
