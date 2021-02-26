using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Covid19KeralaApi.Authorization;

namespace Covid19KeralaApi
{
    [DependsOn(
        typeof(Covid19KeralaApiCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Covid19KeralaApiApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Covid19KeralaApiAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Covid19KeralaApiApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
