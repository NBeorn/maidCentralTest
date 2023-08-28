using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using maidCentralTest.Authorization;

namespace maidCentralTest
{
    [DependsOn(
        typeof(maidCentralTestCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class maidCentralTestApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<maidCentralTestAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(maidCentralTestApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
