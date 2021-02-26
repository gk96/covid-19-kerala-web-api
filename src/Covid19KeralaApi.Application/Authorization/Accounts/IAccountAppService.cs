using System.Threading.Tasks;
using Abp.Application.Services;
using Covid19KeralaApi.Authorization.Accounts.Dto;

namespace Covid19KeralaApi.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
