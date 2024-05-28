using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace RealEstate_Dapper_UI.Services
{


    public class LoginService : ILoginService
    {

        private readonly IHttpContextAccessor _contextaccessor;

        public LoginService(IHttpContextAccessor contextaccessor)
        {
            _contextaccessor = contextaccessor;
        }

        public string GetUserId => _contextaccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
    }
}
