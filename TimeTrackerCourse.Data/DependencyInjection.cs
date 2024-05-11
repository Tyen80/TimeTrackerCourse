using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TimeTrackerCourse.Data.Data;
using TimeTrackerCourse.Data.Repositories.TimeEntryRepository;

namespace TimeTrackerCourse.Data;
public static class DependencyInjection
{
    public static IServiceCollection AddDataLayer(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


        services.AddScoped<ITimeEntryRepository, TimeEntryRepository>();
        return services;
    }
}
