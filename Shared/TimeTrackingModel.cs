using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace zenTime.Shared;

public class TimeTrackingModel
{
    public Guid Id { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public List<HourModel> Hours { get; set; }
}

public class HourModel
{
    public CategoryType Type { get; set; }
    public double HoursAmount { get; set; }
    public TimeTrackingModel TimeTrackingModel { get; set; }
    public Guid Id { get; set; }
}

public enum CategoryType
{
    Unknown = 0,
    MilieuCouns = 1,
    StaffMeetings = 2,
    Education = 3,
    Admin = 4,
    IndvCouns = 5,
    GroupCouns = 6,
    CoupleMarital = 7,
    FamilyCouns = 8,
    Cftm = 9,
    OtherClientContact = 10,
    TestAssessment = 11,
    Intakes = 12,
    IndvSupervision = 13,
    GroupSupervision = 14,
    DirectTotalHours = 15,
    TotalHours = 16
}