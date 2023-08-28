using System.Threading.Tasks;
using Abp.Application.Services;
using maidCentralTest.Sessions.Dto;

namespace maidCentralTest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
