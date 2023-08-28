using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using maidCentralTest.Configuration;

namespace maidCentralTest.Web.Host.Startup
{
    [DependsOn(
       typeof(maidCentralTestWebCoreModule))]
    public class maidCentralTestWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public maidCentralTestWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(maidCentralTestWebHostModule).GetAssembly());
        }
    }
}
