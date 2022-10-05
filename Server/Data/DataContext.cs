using Microsoft.EntityFrameworkCore;
using zenTime.Client.Pages;
using zenTime.Shared;

namespace zenTime.Server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<TimeTrackingModel> TimeTracking { get; set; }
    public DbSet<HourModel> HourModels { get; set; }
}