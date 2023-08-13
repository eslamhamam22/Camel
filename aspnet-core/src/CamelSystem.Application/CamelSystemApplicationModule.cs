using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CamelSystem.Authorization;

namespace CamelSystem
{
    [DependsOn(
        typeof(CamelSystemCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CamelSystemApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CamelSystemAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CamelSystemApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
