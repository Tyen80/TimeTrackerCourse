using Mapster;
using TimeTrackerCourse.Core.Exceptions;
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


    public async Task<List<TimeEntryResponseDto>> GetAllTimeEntries()
    {
        var result = await _timeEntryRepository.GetAllTimeEntries();
        return result.Adapt<List<TimeEntryResponseDto>>();
    }

    public async Task<TimeEntryResponseDto?> GetTimeEntryById(int id)
    {
        var result = await _timeEntryRepository.GetTimeEntryById(id);
        if (result == null)
        {
            throw new Exception("Entry not found");
        }
        return result.Adapt<TimeEntryResponseDto>();
    }

    public async Task<List<TimeEntryResponseDto>> CreateTimeEntries(TimeEntryCreateDto timeEntry)
    {
        var newEntry = timeEntry.Adapt<TimeEntry>();
        var result = await _timeEntryRepository.CreateTimeEntry(newEntry);
        return result.Adapt<List<TimeEntryResponseDto>>();
    }

    public async Task<List<TimeEntryResponseDto>?> UpdateTimeEntry(int id, TimeEntryUpdateDto timeEntry)
    {
        try
        {
            var updatedEntry = timeEntry.Adapt<TimeEntry>();
            var result = await _timeEntryRepository.UpdateTimeEntry(id, updatedEntry);
            return result.Adapt<List<TimeEntryResponseDto>>();
        }
        catch (EntityNotFoundException)
        {
            return null;
        }

    }

    public async Task<List<TimeEntryResponseDto>> DeleteTimeEntry(int id)
    {
        var result = await _timeEntryRepository.DeleteTimeEntry(id);
        if (result == null)
        {
            throw new Exception("Entry not found");
        }
        return result.Adapt<List<TimeEntryResponseDto>>();
    }


}
