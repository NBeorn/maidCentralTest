using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace maidCentralTest.EntityFrameworkCore
{
    public static class maidCentralTestDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<maidCentralTestDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<maidCentralTestDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
