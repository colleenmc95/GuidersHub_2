using UUJ.GuidersHub.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace UUJ.GuidersHub.Web.Host.Controllers
{
    public class AntiForgeryController : GuidersHubControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}