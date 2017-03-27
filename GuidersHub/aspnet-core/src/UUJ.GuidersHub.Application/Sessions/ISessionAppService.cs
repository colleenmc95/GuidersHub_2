using System.Threading.Tasks;
using Abp.Application.Services;
using UUJ.GuidersHub.Sessions.Dto;

namespace UUJ.GuidersHub.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
