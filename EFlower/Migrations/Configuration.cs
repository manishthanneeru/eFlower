namespace EFlower.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFlower.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled =true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "EFlower.Models.ApplicationDbContext";
        }

        protected override void Seed(EFlower.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
