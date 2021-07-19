namespace Infra.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class MigrationConfiguration : DbMigrationsConfiguration<Context.ModelContext>
    {
        public MigrationConfiguration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context.ModelContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
