namespace TestWebApi.Models;

public class Experience
{
    public int Id { get; set; }
    public string Position { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    
    public List<Skill>? Skills { get; set; }
}
