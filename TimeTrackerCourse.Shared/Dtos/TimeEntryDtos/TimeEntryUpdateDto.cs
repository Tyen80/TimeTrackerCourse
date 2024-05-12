namespace TimeTrackerCourse.Shared.Dtos.TimeEntryDtos;



public class TimeEntryUpdateDto
{
    public required string Project { get; set; }
    public DateTime Start { get; set; } = DateTime.Now;
    public DateTime? End { get; set; }
}
