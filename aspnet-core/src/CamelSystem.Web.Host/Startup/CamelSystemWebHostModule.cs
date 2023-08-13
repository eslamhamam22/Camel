using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CamelSystem.Configuration;

namespace CamelSystem.Web.Host.Startup
{
    [DependsOn(
       typeof(CamelSystemWebCoreModule))]
    public class CamelSystemWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CamelSystemWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CamelSystemWebHostModule).GetAssembly());
        }
    }
}
