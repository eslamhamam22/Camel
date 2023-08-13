using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CamelSystem.EntityFrameworkCore;
using CamelSystem.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace CamelSystem.Web.Tests
{
    [DependsOn(
        typeof(CamelSystemWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class CamelSystemWebTestModule : AbpModule
    {
        public CamelSystemWebTestModule(CamelSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CamelSystemWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(CamelSystemWebMvcModule).Assembly);
        }
    }
}