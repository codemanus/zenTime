namespace zenTime.Client.Services;

public interface IHoursService
{
    List<CategoryHoursModel> CategoryHours { get; set; }
    List<SupervisionConsultsModel> SupervisionConsults { get; set; }
    List<DirectContactHoursModel> DirectContactHours { get; set; }

    Task GetCategoryHours();
    Task GetSupervisionHours();
    Task GetDirectContactHours();
}