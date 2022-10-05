using System.Net.Http.Json;

namespace zenTime.Client.Services;

public class HoursService : IHoursService
{
    private readonly HttpClient _httpClient;

    public HoursService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<TimeTrackingModel> TimeTrackingModels { get; set; }
    public TimeTrackingModel TrackingModel { get; set; }

    public Task SetTimeHours()
    {
        throw new NotImplementedException();
    }

    public Task GetHours()
    {
        throw new NotImplementedException();
    }
}