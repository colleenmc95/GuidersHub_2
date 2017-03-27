using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using UUJ.GuidersHub.MultiTenancy;

namespace UUJ.GuidersHub.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}