namespace TestWebApi.Models;

public class Skill
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Level { get; set; }
    
    public List<Candidate>? Candidates { get; set; }
    public List<Job>? Jobs { get; set; }
    public List<Experience>? Experience { get; set; }
}