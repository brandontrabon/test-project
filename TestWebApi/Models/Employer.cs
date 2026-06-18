namespace TestWebApi.Models;

public class Employer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public required State State { get; set; }
    public string PostalCode { get; set; } = string.Empty;
}