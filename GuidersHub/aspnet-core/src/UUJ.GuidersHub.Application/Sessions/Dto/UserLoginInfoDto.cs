using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using UUJ.GuidersHub.Authorization.Users;
using UUJ.GuidersHub.Users;

namespace UUJ.GuidersHub.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}
