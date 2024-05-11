using Mapster;
using TimeTrackerCourse.Data.Repositories.TimeEntryRepository;
using TimeTrackerCourse.Shared.Dtos.TimeEntryDtos;
using TimeTrackerCourse.Shared.Entities;

namespace TimeTrackerCourse.Service.Services.TimeEntryService;
public class TimeEntryservice : ITimeEntryService
{
    private readonly ITimeEntryRepository _timeEntryRepository;

    public TimeEntryservice(ITimeEntryRepository timeEntryRepository)
    {
        _timeEntryRepository = timeEntryRepository;
    }


    public List<TimeEntryResponseDto> GetAllTimeEntries()
    {
        var result = _timeEntryRepository.GetAllTimeEntries();
        return result.Adapt<List<TimeEntryResponseDto>>();
    }

    public TimeEntryResponseDto GetTimeEntry(int id)
    {
        var result = _timeEntryRepository.GetTimeEntryById(id);
        if (result == null)
        {
            throw new Exception("Entry not found");
        }
        return result.Adapt<TimeEntryResponseDto>();
    }

    public List<TimeEntryResponseDto> GetTimeEntries(TimeEntryCreateDto timeEntry)
    {
        var newEntry = timeEntry.Adapt<TimeEntry>();
        var result = _timeEntryRepository.CreateTimeEntry(newEntry);
        return result.Adapt<List<TimeEntryResponseDto>>();
    }

    public List<TimeEntryResponseDto> UpdateTimeEntry(int id, TimeEntryUpdateDto timeEntry)
    {
        var updatedEntry = timeEntry.Adapt<TimeEntry>();
        var result = _timeEntryRepository.UpdateTimeEntry(id, updatedEntry);
        if (result == null)
        {
            throw new Exception("Entry not found");
        }
        return result.Adapt<List<TimeEntryResponseDto>>();
    }

    public List<TimeEntryResponseDto> DeleteTimeEntry(int id)
    {
        var result = _timeEntryRepository.DeleteTimeEntry(id);
        if (result == null)
        {
            throw new Exception("Entry not found");
        }
        return result.Adapt<List<TimeEntryResponseDto>>();
    }


}
