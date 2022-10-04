namespace zenTime.Shared;

public class DirectContactHoursModel
{
    public int Id { get; set; }
    public static double IndvCouns { get; set; }
    public static double GroupCouns { get; set; }
    public static double CoupleMarital { get; set; }
    public static double FamilyCouns { get; set; }
    public static double CFTM { get; set; }
    public static double OtherClientContact { get; set; }
    public static double TestAssessment { get; set; }
    public static double Intakes { get; set; }
    public double DirectTotalHours { get; set; }
}