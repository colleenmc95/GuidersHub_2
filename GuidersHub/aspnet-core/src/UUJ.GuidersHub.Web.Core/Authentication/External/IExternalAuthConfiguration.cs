using System.Collections.Generic;

namespace UUJ.GuidersHub.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
