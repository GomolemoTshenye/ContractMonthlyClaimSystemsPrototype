namespace ContractMonthlyClaimSystemsPrototype.Migrations.Claims
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContractMonthlyClaimSystemsPrototype.Models.ClaimsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Claims";
        }

        protected override void Seed(ContractMonthlyClaimSystemsPrototype.Models.ClaimsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
