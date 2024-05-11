using Microsoft.AspNetCore.Mvc;
using TimeTrackerCourse.Shared.Entities;

namespace TimeTrackerCourse.Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TimeEntryController : ControllerBase
{
    private static List<TimeEntry> _timeEntries = new List<TimeEntry>
    {
        new TimeEntry { Id = 1, Project = "Project 1", Start = DateTime.Now.AddHours(-2), End = DateTime.Now.AddHours(-1) },
        new TimeEntry { Id = 2, Project = "Project 2", Start = DateTime.Now.AddHours(-1), End = DateTime.Now },
        new TimeEntry { Id = 3, Project = "Project 3", Start = DateTime.Now.AddHours(-3), End = DateTime.Now.AddHours(-2) }

    };

    [HttpGet]
    public ActionResult<List<TimeEntry>> GetAllTimeEntrys()
    {
        return Ok(_timeEntries);
    }

    [HttpPost]
    public ActionResult<List<TimeEntry>> CreateTimeEntry(TimeEntry timeEntry)
    {
        _timeEntries.Add(timeEntry);
        return Ok(_timeEntries);
    }
}
