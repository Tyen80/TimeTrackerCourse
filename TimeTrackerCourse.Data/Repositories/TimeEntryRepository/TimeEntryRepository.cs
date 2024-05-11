using Microsoft.EntityFrameworkCore;
using TimeTrackerCourse.Core.Exceptions;
using TimeTrackerCourse.Data.Data;
using TimeTrackerCourse.Shared.Entities;

namespace TimeTrackerCourse.Data.Repositories.TimeEntryRepository;
public class TimeEntryRepository : ITimeEntryRepository
{
    public TimeEntryRepository(DataContext context)
    {
        _context = context;
    }

    private static List<TimeEntry> _timeEntries = new List<TimeEntry>
    {
        new TimeEntry { Id = 1, Project = "Project 1", Start = DateTime.Now.AddHours(-2), End = DateTime.Now.AddHours(-1) },
        new TimeEntry { Id = 2, Project = "Project 2", Start = DateTime.Now.AddHours(-1), End = DateTime.Now },
        new TimeEntry { Id = 3, Project = "Project 3", Start = DateTime.Now.AddHours(-3), End = DateTime.Now.AddHours(-2) }

    };
    private readonly DataContext _context;

    public async Task<List<TimeEntry>> GetAllTimeEntries()
    {
        return await _context.TimeEntries.ToListAsync();
    }

    public async Task<TimeEntry?> GetTimeEntryById(int id)
    {
        var timeEntry = await _context.TimeEntries.FindAsync(id);
        return timeEntry;
    }

    public async Task<List<TimeEntry>> CreateTimeEntry(TimeEntry timeEntry)
    {
        _context.TimeEntries.Add(timeEntry);
        await _context.SaveChangesAsync();
        return await _context.TimeEntries.ToListAsync();
    }

    public async Task<List<TimeEntry>?> UpdateTimeEntry(int id, TimeEntry timeEntry)
    {
        var dbtimeEntry = await _context.TimeEntries.FindAsync(id);
        if (dbtimeEntry == null)
        {
            throw new EntityNotFoundException($"Time Entry with {id} was not found");
        }

        dbtimeEntry.Project = timeEntry.Project;
        dbtimeEntry.Start = timeEntry.Start;
        dbtimeEntry.End = timeEntry.End;
        dbtimeEntry.DateUpdated = DateTime.Now;
        await _context.SaveChangesAsync();
        return await GetAllTimeEntries();
    }

    public async Task<List<TimeEntry>?> DeleteTimeEntry(int id)
    {
        var dbtimeEntry = await _context.TimeEntries.FindAsync(id);
        if (dbtimeEntry == null)
        {
            return null;
        }
        _context.TimeEntries.Remove(dbtimeEntry);
        await _context.SaveChangesAsync();
        return await GetAllTimeEntries();
    }


}
