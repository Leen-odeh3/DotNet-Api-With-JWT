using DotNetApiWithJWT.Api.Models;

namespace DotNetApiWithJWT.Api.Abstracts;

public interface IAuthService
{
    Task<AuthModel> RegisterAsync(RegisterModel model);
    Task<AuthModel> GetTokenAsync(TokenRequestModel model);
    Task<string> AddRoleAsync(AddRoleModel model);
}
