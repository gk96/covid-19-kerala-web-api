using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Covid19KeralaApi.Configuration;

namespace Covid19KeralaApi.Web.Host.Startup
{
    [DependsOn(
       typeof(Covid19KeralaApiWebCoreModule))]
    public class Covid19KeralaApiWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Covid19KeralaApiWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Covid19KeralaApiWebHostModule).GetAssembly());
        }
    }
}
