using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Wingap.EntityFrameworkCore;
using Wingap.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Wingap.Web.Tests
{
    [DependsOn(
        typeof(WingapWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class WingapWebTestModule : AbpModule
    {
        public WingapWebTestModule(WingapEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WingapWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(WingapWebMvcModule).Assembly);
        }
    }
}