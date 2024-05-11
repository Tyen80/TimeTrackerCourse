using TimeTrackerCourse.Shared.Entities;

namespace TimeTrackerCourse.Data.Repositories.TimeEntryRepository;
public class TimeEntryRepository : ITimeEntryRepository
{
    private static List<TimeEntry> _timeEntries = new List<TimeEntry>
    {
        new TimeEntry { Id = 1, Project = "Project 1", Start = DateTime.Now.AddHours(-2), End = DateTime.Now.AddHours(-1) },
        new TimeEntry { Id = 2, Project = "Project 2", Start = DateTime.Now.AddHours(-1), End = DateTime.Now },
        new TimeEntry { Id = 3, Project = "Project 3", Start = DateTime.Now.AddHours(-3), End = DateTime.Now.AddHours(-2) }

    };

    public List<TimeEntry> GetAllTimeEntries()
    {
        return _timeEntries;
    }

    public TimeEntry? GetTimeEntryById(int id)
    {
        return _timeEntries.FirstOrDefault(x => x.Id == id);

    }

    public List<TimeEntry> CreateTimeEntry(TimeEntry timeEntry)
    {
        _timeEntries.Add(timeEntry);
        return _timeEntries;
    }

    public List<TimeEntry>? UpdateTimeEntry(int id, TimeEntry timeEntry)
    {
        var entryToUpdate = _timeEntries.FindIndex(x => x.Id == id);
        if (entryToUpdate == -1)
        {
            return null;

        }
        _timeEntries[entryToUpdate] = timeEntry;
        return _timeEntries;
    }

    public List<TimeEntry>? DeleteTimeEntry(int id)
    {
        var entryToDelete = _timeEntries.FirstOrDefault(x => x.Id == id);
        if (entryToDelete == null)
        {
            return null;
        }
        _timeEntries.Remove(entryToDelete);
        return _timeEntries;
    }


}
