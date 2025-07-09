using SignUpApi.DTOs;

namespace SignUpApi.IService
{
    public interface IAuthService
    {
        Task<(bool success, string message)> RegisterUserAsync(UserSignUpDto request);
        Task<(bool success, string message, string token)> LoginUserAsync(UserLoginDto request);

    }
}
