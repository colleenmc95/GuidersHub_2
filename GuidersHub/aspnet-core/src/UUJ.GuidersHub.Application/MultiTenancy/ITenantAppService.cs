using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using UUJ.GuidersHub.MultiTenancy.Dto;

namespace UUJ.GuidersHub.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
