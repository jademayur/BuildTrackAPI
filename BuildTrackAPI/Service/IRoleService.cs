using BuildTrackAPI.DTOs.RoleDTOs;
using BuildTrackAPI.models;

namespace BuildTrackAPI.Service
{
    public interface IRoleService
    {
        Task<IEnumerable<Role>> GetAllAsync();
        Task<Role> GetByIdAsync(int id);
        Task<string> CreateAsync(RoleCreateDto dto);
        Task<string> UpdateAsync(RoleUpdateDto dto);
        Task<string> DeleteAsync(int id);
    }
}
