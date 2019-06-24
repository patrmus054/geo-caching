namespace Keszobranie.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Keszobranie.Models.GeoCacheContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        
        protected override void Seed(Keszobranie.Models.GeoCacheContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
