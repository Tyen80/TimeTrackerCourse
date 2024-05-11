using Microsoft.AspNetCore.Mvc;
using TimeTrackerCourse.Service.Services.TimeEntryService;
using TimeTrackerCourse.Shared.Dtos.TimeEntryDtos;

namespace TimeTrackerCourse.Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TimeEntryController : ControllerBase
{
    private readonly ITimeEntryService _timeEntryService;

    public TimeEntryController(ITimeEntryService timeEntryService)
    {
        _timeEntryService = timeEntryService;
    }

    [HttpGet]
    public ActionResult<List<TimeEntryResponseDto>> GetAllTimeEntrys()
    {
        var result = _timeEntryService.GetAllTimeEntries();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public ActionResult<TimeEntryResponseDto> GetTimeEntry(int id)
    {
        var result = _timeEntryService.GetAllTimeEntries().FirstOrDefault(x => x.Id == id);
        if (result == null)
        {
            return NotFound();
        }
        return Ok(result);
    }


    [HttpPost]
    public ActionResult<List<TimeEntryResponseDto>> CreateTimeEntry(TimeEntryCreateDto timeEntry)
    {
        return Ok(_timeEntryService.GetTimeEntries(timeEntry));
    }

    [HttpPut("{id}")]
    public ActionResult<List<TimeEntryResponseDto>> UpdateTimeEntry(int id, TimeEntryUpdateDto timeEntry)
    {
        return Ok(_timeEntryService.UpdateTimeEntry(id, timeEntry));
    }

    [HttpDelete("{id}")]
    public ActionResult<List<TimeEntryResponseDto>> DeleteTimeEntry(int id)
    {
        return Ok(_timeEntryService.DeleteTimeEntry(id));
    }
}
