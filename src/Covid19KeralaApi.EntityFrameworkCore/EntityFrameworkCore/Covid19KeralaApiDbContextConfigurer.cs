using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Covid19KeralaApi.EntityFrameworkCore
{
    public static class Covid19KeralaApiDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Covid19KeralaApiDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Covid19KeralaApiDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
