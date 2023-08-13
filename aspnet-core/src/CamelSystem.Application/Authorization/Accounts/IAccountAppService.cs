using System.Threading.Tasks;
using Abp.Application.Services;
using CamelSystem.Authorization.Accounts.Dto;

namespace CamelSystem.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
