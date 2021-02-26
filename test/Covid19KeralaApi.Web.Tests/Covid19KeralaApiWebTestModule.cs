using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Covid19KeralaApi.EntityFrameworkCore;
using Covid19KeralaApi.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Covid19KeralaApi.Web.Tests
{
    [DependsOn(
        typeof(Covid19KeralaApiWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class Covid19KeralaApiWebTestModule : AbpModule
    {
        public Covid19KeralaApiWebTestModule(Covid19KeralaApiEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Covid19KeralaApiWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(Covid19KeralaApiWebMvcModule).Assembly);
        }
    }
}