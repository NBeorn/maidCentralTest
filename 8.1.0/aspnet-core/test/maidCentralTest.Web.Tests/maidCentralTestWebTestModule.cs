using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using maidCentralTest.EntityFrameworkCore;
using maidCentralTest.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace maidCentralTest.Web.Tests
{
    [DependsOn(
        typeof(maidCentralTestWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class maidCentralTestWebTestModule : AbpModule
    {
        public maidCentralTestWebTestModule(maidCentralTestEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(maidCentralTestWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(maidCentralTestWebMvcModule).Assembly);
        }
    }
}