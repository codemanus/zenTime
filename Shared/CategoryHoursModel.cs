namespace zenTime.Shared;

public class CategoryHoursModel
{
    public int Id { get; set; }
    public DateOnly DateOnly { get; set; }
    public DirectContactHoursModel? DirectContactHours { get; set; }
    public static double MilieuCouns { get; set; }
    public static double StaffMeetings { get; set; }
    public static double Education { get; set; }
    public static double Admin { get; set; }
    public SupervisionConsultsModel? SupervisionConsults { get; set; }
    public double? DailyTotals { get; set; }
    public double TotalHours { get; set; }
}