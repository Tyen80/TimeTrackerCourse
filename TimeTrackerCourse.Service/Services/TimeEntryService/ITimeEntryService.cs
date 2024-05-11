using TimeTrackerCourse.Shared.Dtos.TimeEntryDtos;

namespace TimeTrackerCourse.Service.Services.TimeEntryService;
public interface ITimeEntryService
{
    List<TimeEntryResponseDto> GetAllTimeEntries();
    TimeEntryResponseDto? GetTimeEntry(int id);
    List<TimeEntryResponseDto> GetTimeEntries(TimeEntryCreateDto timeEntry);
    List<TimeEntryResponseDto> UpdateTimeEntry(int id, TimeEntryUpdateDto timeEntry);
    List<TimeEntryResponseDto> DeleteTimeEntry(int id);
}
