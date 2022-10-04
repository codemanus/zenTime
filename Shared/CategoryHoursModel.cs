namespace zenTime.Shared;

public class CategoryHoursModel
{
    public int Id { get; set; }
    public DateTime DateTimeFrom { get; set; }
    public DateTime DateTimeTo { get; set; }
    public DirectContactHoursModel? DirectContactHours { get; set; }
    public double MilieuCouns { get; set; }
    public double StaffMeetings { get; set; }
    public double Education { get; set; }
    public double Admin { get; set; }
    public SupervisionConsultsModel? SupervisionConsults { get; set; }
    public double DailyTotals { get; set; }
    public double TotalHours { get; set; }
}