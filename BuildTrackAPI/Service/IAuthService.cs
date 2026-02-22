using BuildTrackAPI.DTOs;
using BuildTrackAPI.DTOs.CompanySelect;

namespace BuildTrackAPI.Service
{
    public interface IAuthService
    {
        Task<object> LoginAsync(LoginDto dto);
        Task<string> GenerateTokenAsync(CompanySelectionDto dto);
    }
}
