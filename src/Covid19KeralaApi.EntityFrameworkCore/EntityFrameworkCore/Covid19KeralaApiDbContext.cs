using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Covid19KeralaApi.Authorization.Roles;
using Covid19KeralaApi.Authorization.Users;
using Covid19KeralaApi.MultiTenancy;

namespace Covid19KeralaApi.EntityFrameworkCore
{
    public class Covid19KeralaApiDbContext : AbpZeroDbContext<Tenant, Role, User, Covid19KeralaApiDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public Covid19KeralaApiDbContext(DbContextOptions<Covid19KeralaApiDbContext> options)
            : base(options)
        {
        }
    }
}
