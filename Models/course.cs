namespace CourseMgr.Models;

public class Course{
    public required string Code {get; set;}
    public required string Title {get; set;}
    public required int Credit {get; set;}
    public String? Description {get; set;}
}