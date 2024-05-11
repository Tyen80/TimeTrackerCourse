using TimeTrackerCourse.Shared.Entities;

namespace TimeTrackerCourse.Data.Repositories.TimeEntryRepository;
public interface ITimeEntryRepository
{
    List<TimeEntry> GetAllTimeEntries();
    TimeEntry? GetTimeEntryById(int id);
    List<TimeEntry> CreateTimeEntry(TimeEntry timeEntry);
    List<TimeEntry>? UpdateTimeEntry(int id, TimeEntry timeEntry);
    List<TimeEntry>? DeleteTimeEntry(int id);

}
