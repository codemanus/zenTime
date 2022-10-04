using Microsoft.EntityFrameworkCore;
using zenTime.Server.Data;
using zenTime.Shared;

namespace zenTime.Server.Services;

public class HoursService : IHoursService
{
    private readonly DataContext _context;

    public HoursService(DataContext context)
    {
        _context = context;
    }

    public async Task<ServiceResponse<List<CategoryHoursModel>>> GetCategoryHours()
    {
        var categories = await _context.CategoryHours
            .ToListAsync();
        return new ServiceResponse<List<CategoryHoursModel>>
        {
            Data = categories
        };
    }

    public Task<ServiceResponse<List<CategoryHoursModel>>> AddCategoryHours()
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<List<CategoryHoursModel>>> UpdateCategoryHours()
    {
        throw new NotImplementedException();
    }
}