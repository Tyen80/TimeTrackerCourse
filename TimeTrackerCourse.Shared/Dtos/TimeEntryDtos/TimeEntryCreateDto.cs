namespace TimeTrackerCourse.Shared.Dtos.TimeEntryDtos;

public record struct TimeEntryCreateDto(string Project, DateTime Start, DateTime? End = null);

//public class TimeEntryCreateDto
//{
//    public required string Project { get; set; }
//    public DateTime Start { get; set; } = DateTime.Now;
//    public DateTime? End { get; set; }
//}
