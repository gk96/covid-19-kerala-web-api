using System.Threading.Tasks;
using Abp.Application.Services;
using Covid19KeralaApi.Sessions.Dto;

namespace Covid19KeralaApi.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
