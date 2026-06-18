namespace TestWebApi.Models;

public class Job
{
    public int Id { get; set; }
    public required Employer Employer { get; set; }
    public string Description { get; set; } = string.Empty;
    
    public List<Skill>? Skills { get; set; }
}