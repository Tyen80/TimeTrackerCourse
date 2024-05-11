using TimeTrackerCourse.Shared.Dtos.TimeEntryDtos;

namespace TimeTrackerCourse.Service.Services.TimeEntryService;
public interface ITimeEntryService
{
    Task<List<TimeEntryResponseDto>> GetAllTimeEntries();
    Task<TimeEntryResponseDto?> GetTimeEntryById(int id);
    Task<List<TimeEntryResponseDto>> CreateTimeEntries(TimeEntryCreateDto timeEntry);
    Task<List<TimeEntryResponseDto>?> UpdateTimeEntry(int id, TimeEntryUpdateDto timeEntry);
    Task<List<TimeEntryResponseDto>> DeleteTimeEntry(int id);
}
