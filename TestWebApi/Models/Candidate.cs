namespace TestWebApi.Models;

public class Candidate
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public required State State { get; set; }
    public string PostalCode { get; set; } = string.Empty;
    
    public List<Skill>? Skills { get; set; }
}
