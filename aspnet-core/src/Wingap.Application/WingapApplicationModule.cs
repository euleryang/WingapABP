using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Wingap.Authorization;

namespace Wingap
{
    [DependsOn(
        typeof(WingapCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class WingapApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<WingapAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(WingapApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
