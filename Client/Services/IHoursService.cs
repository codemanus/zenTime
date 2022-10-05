namespace zenTime.Client.Services;

public interface IHoursService
{
    List<TimeTrackingModel> TimeTrackingModels { get; set; }
    public TimeTrackingModel TrackingModel { get; set; }
    Task SetTimeHours();
    Task GetHours();
}