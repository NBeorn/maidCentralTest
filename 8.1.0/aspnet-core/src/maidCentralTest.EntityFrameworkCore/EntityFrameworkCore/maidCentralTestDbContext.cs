using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using maidCentralTest.Authorization.Roles;
using maidCentralTest.Authorization.Users;
using maidCentralTest.MultiTenancy;
using maidCentralTest.StartingValues;

namespace maidCentralTest.EntityFrameworkCore
{
    public class maidCentralTestDbContext : AbpZeroDbContext<Tenant, Role, User, maidCentralTestDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<StartingValue> StartingValues { get; set; }
        
        public maidCentralTestDbContext(DbContextOptions<maidCentralTestDbContext> options)
            : base(options)
        {
        }
    }
}
