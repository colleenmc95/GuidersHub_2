using Abp.AutoMapper;
using UUJ.GuidersHub.Authentication.External;

namespace UUJ.GuidersHub.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
