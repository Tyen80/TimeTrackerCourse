using Microsoft.Extensions.DependencyInjection;
using TimeTrackerCourse.Service.Services.TimeEntryService;

namespace TimeTrackerCourse.Service;
public static class DependencyInjection
{
    public static IServiceCollection AddServiceLayer(this IServiceCollection services)
    {
        services.AddScoped<ITimeEntryService, TimeEntryservice>();
        return services;
    }
}
