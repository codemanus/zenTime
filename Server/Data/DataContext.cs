using Microsoft.EntityFrameworkCore;
using zenTime.Shared;

namespace zenTime.Server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoryHoursModel>().HasData(
            new CategoryHoursModel
            {
                Id = 1,
                DateTimeFrom = DateTime.Now.Date,
                DateTimeTo = DateTime.Now.AddDays(5).Date,
                MilieuCouns = 12,
                StaffMeetings = 13,
                Education = 5,
                Admin = 1.3,
                DailyTotals = 35,
                TotalHours = 48
            }
        );
        modelBuilder.Entity<DirectContactHoursModel>().HasData(
            new DirectContactHoursModel
            {
                Id = 1,
                IndvCouns = 20,
                GroupCouns = 1,
                CoupleMarital = 1,
                FamilyCouns = 0,
                CFTM = 1,
                OtherClientContact = 1.5d,
                TestAssessment = 3.2d,
                Intakes = 4,
                DirectTotalHours = 33.8d
            }
        );
        modelBuilder.Entity<SupervisionConsultsModel>().HasData(
            new SupervisionConsultsModel
            {
                Id = 1,
                Individual = 1,
                Group = 1
            }
        );
    }

    public DbSet<CategoryHoursModel> CategoryHours { get; set; }
    public DbSet<DirectContactHoursModel> DirectContactHours { get; set; }
    public DbSet<SupervisionConsultsModel> SupervisionConsults { get; set; }
}