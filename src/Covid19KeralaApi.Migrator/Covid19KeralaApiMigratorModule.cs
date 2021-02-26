using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Covid19KeralaApi.Configuration;
using Covid19KeralaApi.EntityFrameworkCore;
using Covid19KeralaApi.Migrator.DependencyInjection;

namespace Covid19KeralaApi.Migrator
{
    [DependsOn(typeof(Covid19KeralaApiEntityFrameworkModule))]
    public class Covid19KeralaApiMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public Covid19KeralaApiMigratorModule(Covid19KeralaApiEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(Covid19KeralaApiMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                Covid19KeralaApiConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Covid19KeralaApiMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
