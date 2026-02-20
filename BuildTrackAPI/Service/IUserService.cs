using BuildTrackAPI.DTOs.User;
using BuildTrackAPI.models;

namespace BuildTrackAPI.Service
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task<string> CreateAsync(UserCreateDto dto);
        Task<string> UpdateAsync(UserUpdateDto dto);
        Task<string> DeleteAsync(int id);
    }
}
