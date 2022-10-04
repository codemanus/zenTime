using System.Net.Http.Json;

namespace zenTime.Client.Services;

public class HoursService : IHoursService
{
    private readonly HttpClient _httpClient;

    public HoursService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<CategoryHoursModel> CategoryHours { get; set; } = new List<CategoryHoursModel>();
    public List<SupervisionConsultsModel> SupervisionConsults { get; set; } = new List<SupervisionConsultsModel>();
    public List<DirectContactHoursModel> DirectContactHours { get; set; } = new List<DirectContactHoursModel>();

    public async Task GetCategoryHours()
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<CategoryHoursModel>>>("api/Hours");
        if (response != null && response.Data != null)
            CategoryHours = response.Data;
    }

    public async Task GetSupervisionHours()
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<SupervisionConsultsModel>>>("api/Hours");
        if (response != null && response.Data != null)
            SupervisionConsults = response.Data;
    }

    public async Task GetDirectContactHours()
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<DirectContactHoursModel>>>("api/Hours");
        if (response != null && response.Data != null)
            DirectContactHours = response.Data;
    }
}