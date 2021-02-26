using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Covid19KeralaApi.Configuration;
using Covid19KeralaApi.Web;

namespace Covid19KeralaApi.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Covid19KeralaApiDbContextFactory : IDesignTimeDbContextFactory<Covid19KeralaApiDbContext>
    {
        public Covid19KeralaApiDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Covid19KeralaApiDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Covid19KeralaApiDbContextConfigurer.Configure(builder, configuration.GetConnectionString(Covid19KeralaApiConsts.ConnectionStringName));

            return new Covid19KeralaApiDbContext(builder.Options);
        }
    }
}
