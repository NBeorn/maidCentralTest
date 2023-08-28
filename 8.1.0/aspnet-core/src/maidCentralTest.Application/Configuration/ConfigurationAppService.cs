using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using maidCentralTest.Configuration.Dto;

namespace maidCentralTest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : maidCentralTestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
