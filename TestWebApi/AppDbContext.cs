using Microsoft.EntityFrameworkCore;
using TestWebApi.Models;

namespace TestWebApi;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Candidate> Candidates { get; set; }
    public DbSet<Employer> Employers { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<State> States { get; set; }
}