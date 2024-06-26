﻿using TimeTrackerCourse.Shared.Entities;

namespace TimeTrackerCourse.Data.Repositories.TimeEntryRepository;
public interface ITimeEntryRepository
{
    Task<List<TimeEntry>> GetAllTimeEntries();
    Task<TimeEntry?> GetTimeEntryById(int id);
    Task<List<TimeEntry>> CreateTimeEntry(TimeEntry timeEntry);
    Task<List<TimeEntry>?> UpdateTimeEntry(int id, TimeEntry timeEntry);
    Task<List<TimeEntry>?> DeleteTimeEntry(int id);

}
