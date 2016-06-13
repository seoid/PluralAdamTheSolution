using TheSolution.Model;

namespace TheSolution.DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TheSolution.DataLayer.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TheSolution.DataLayer.SalesContext context)
        {
            context.SalesOrders.AddOrUpdate(
                so => so.CustomerName,
                new SalesOrder{CustomerName = "Adam", PONumber = "NotWorkin"},
                new SalesOrder{CustomerName = "Brian", PONumber = "123456"},
                new SalesOrder{CustomerName = "Carla", PONumber = "PL00012"},
                new SalesOrder{CustomerName = "Daniel", PONumber = "MO332322"}
                );
        }
    }
}
