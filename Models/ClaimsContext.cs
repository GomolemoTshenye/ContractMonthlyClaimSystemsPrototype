using System.Data.Entity;

namespace ContractMonthlyClaimSystemsPrototype.Models
{
    public class ClaimsContext : DbContext
    {
        public ClaimsContext() : base("DefaultConnection")
        {
        }

        public DbSet<Claim> Claims { get; set; }
    }
}