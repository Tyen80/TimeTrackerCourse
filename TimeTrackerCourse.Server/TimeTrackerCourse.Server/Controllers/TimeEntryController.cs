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
    public async Task<ActionResult<TimeEntryResponseDto>> GetTimeEntry(int id)
    {
        var result = await _timeEntryService.GetTimeEntryById(id);
        if (result == null)
        {
            return NotFound();
        }
        return Ok(result);
    }


    [HttpPost]
    public async Task<ActionResult<List<TimeEntryResponseDto>>> CreateTimeEntry(TimeEntryCreateDto timeEntry)
    {
        return Ok(await _timeEntryService.CreateTimeEntries(timeEntry));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<List<TimeEntryResponseDto>>> UpdateTimeEntry(int id, TimeEntryUpdateDto timeEntry)
    {
        var result = await _timeEntryService.UpdateTimeEntry(id, timeEntry);
        if (result == null)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<TimeEntryResponseDto>>> DeleteTimeEntry(int id)
    {
        var result = await _timeEntryService.DeleteTimeEntry(id);
        if (result == null)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
