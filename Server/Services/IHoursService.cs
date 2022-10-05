using MudBlazor;
using zenTime.Shared;

namespace zenTime.Server.Services;

public interface IHoursService
{
    Task<ServiceResponse<List<TimeTrackingModel>>> GetHours();
    Task<ServiceResponse<List<TimeTrackingModel>>> SetHours();
}