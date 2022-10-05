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
        /*
         * TODO:
         * Need to build Save logic
         *
         * Need to be able to bind the values that are entered from the
         * HoursForm.razor into the model to save to the database
         * 
         */

        throw new NotImplementedException();
    }

    public Task GetHours()
    {
        /*
         * TODO:
         * Need to build the get logic to Get the hours for the overall totals accumulated thus far
         */

        throw new NotImplementedException();
    }
}