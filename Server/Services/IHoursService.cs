using zenTime.Shared;

namespace zenTime.Server.Services;

public interface IHoursService
{
    Task<ServiceResponse<List<CategoryHoursModel>>> GetCategoryHours();
    Task<ServiceResponse<List<CategoryHoursModel>>> AddCategoryHours();
    Task<ServiceResponse<List<CategoryHoursModel>>> UpdateCategoryHours();
}