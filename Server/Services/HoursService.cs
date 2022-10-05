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

    public async Task<ServiceResponse<List<TimeTrackingModel>>> GetHours()
    {
        var timeTrack = await _context.TimeTracking
            .ToListAsync();
        return new ServiceResponse<List<TimeTrackingModel>>
        {
            Data = timeTrack
        };
    }

    public async Task<ServiceResponse<List<TimeTrackingModel>>> SetHours()
    {
        throw new NotImplementedException();
    }
}