using System.Threading.Tasks;
using Abp.Application.Services;
using UUJ.GuidersHub.Roles.Dto;

namespace UUJ.GuidersHub.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
