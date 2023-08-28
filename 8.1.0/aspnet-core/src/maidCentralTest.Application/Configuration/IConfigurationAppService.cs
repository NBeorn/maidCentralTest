using System.Threading.Tasks;
using maidCentralTest.Configuration.Dto;

namespace maidCentralTest.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
