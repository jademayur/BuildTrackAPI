using BuildTrackAPI.DTOs;

namespace BuildTrackAPI.Service
{
    public interface IAuthService
    {
        Task<string> LoginAsync(LoginDto dto);
    }
}
