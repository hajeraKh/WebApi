namespace work_01.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using work_01.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<work_01.Models.DeviceDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(work_01.Models.DeviceDbContext context)
        {
            Device d = new Device { DeviceName = "IPhone", ReleaseDate = new DateTime(2023, 2, 1), OnSales = true, Picture = "1.jpg", Price = 120000 };
            d.Specs.Add(new Spec { SpecName = "RAM", Value = "128GB" });
            d.Specs.Add(new Spec { SpecName = "Storage", Value = "256GB" });
            context.Devices.Add(d);
            context.SaveChanges();
        }
    }
}
