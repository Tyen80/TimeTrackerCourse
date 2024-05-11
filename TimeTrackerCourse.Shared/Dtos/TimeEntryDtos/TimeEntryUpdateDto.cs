namespace TimeTrackerCourse.Shared.Dtos.TimeEntryDtos;

public record struct TimeEntryUpdateDto(string Project, DateTime Start, DateTime? End);


//public class TimeEntryUpdateDto
//{
//    public required string Project { get; set; }
//    public DateTime Start { get; set; } = DateTime.Now;
//    public DateTime? End { get; set; }
//}
