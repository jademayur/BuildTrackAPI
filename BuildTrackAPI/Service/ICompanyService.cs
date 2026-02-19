using BuildTrackAPI.DTOs.CompanyDTOs;

namespace BuildTrackAPI.Service
{
    public interface ICompanyService
    {
        Task<CompanyResponseDto> CreateCompanyAsync(CompanyCreateDto dto, int userId);

        Task<List<CompanyResponseDto>> GetAllCompaniesAsync();

        Task<CompanyResponseDto> GetByIdAsync(int id);

        Task<bool> UpdateCompanyAsync(int id, CompanyUpdateDto dto, int userId);

        Task<bool> DeleteCompanyAsync(int id, int userId);
    }
}
