using System.Threading.Tasks;
using Abp.Application.Services;
using CamelSystem.Sessions.Dto;

namespace CamelSystem.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
