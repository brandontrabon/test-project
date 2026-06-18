using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestWebApi.Models;

namespace TestWebApi.Controllers;

[Route("api/[controller]")]
public class CandidateController(AppDbContext context) : Controller
{
    [HttpGet]
    public List<Candidate> Get()
    {
        return context.Candidates.ToList();
    }

    [HttpGet("{id:int}/skills")]
    public List<Skill> GetSkills(int id)
    {
        var candidate = context.Candidates.Include(candidate => candidate.Skills).FirstOrDefault(candidate => candidate.Id == id);
        return candidate?.Skills ?? [];
    }

    [HttpGet("{id:int}/jobs")]
    public List<Job> GetJobs(int id)
    {
        var candidate = context.Candidates.Include(candidate => candidate.Skills).ThenInclude(skill => skill.Jobs).FirstOrDefault(candidate => candidate.Id == id);
        var skills = candidate?.Skills?.ToList();
        return skills == null ? [] : skills.SelectMany(skill => skill.Jobs).ToList();
    }

    [HttpPost]
    public Candidate Create(Candidate candidate)
    {
        context.Candidates.Add(candidate);
        context.SaveChanges();
        return candidate;
    }
}