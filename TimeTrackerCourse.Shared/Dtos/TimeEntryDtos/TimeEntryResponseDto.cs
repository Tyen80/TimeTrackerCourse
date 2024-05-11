namespace TimeTrackerCourse.Shared.Dtos.TimeEntryDtos;

public record struct TimeEntryResponseDto(int id, string Project, DateTime Start, DateTime? End);


//public class TimeEntryResponseDto
//{
//    public int Id { get; set; }
//    public required string Project { get; set; }
//    public DateTime Start { get; set; } = DateTime.Now;
//    public DateTime? End { get; set; }
//}
