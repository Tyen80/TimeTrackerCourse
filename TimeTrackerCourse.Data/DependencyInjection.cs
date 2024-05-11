using Microsoft.Extensions.DependencyInjection;
using TimeTrackerCourse.Data.Repositories.TimeEntryRepository;

namespace TimeTrackerCourse.Data;
public static class DependencyInjection
{
    public static IServiceCollection AddDataLayer(this IServiceCollection services)
    {
        services.AddScoped<ITimeEntryRepository, TimeEntryRepository>();
        return services;
    }
}
