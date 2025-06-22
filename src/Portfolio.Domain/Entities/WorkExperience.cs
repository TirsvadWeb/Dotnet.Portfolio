// Domain/Entities/WorkExperience.cs
namespace Portfolio.Domain.Entities;

/// <summary>
/// Represents a professional experience entry.
/// </summary>
public class WorkExperience : BaseEntity
{
    public string Company { get; private set; }
    public string Role { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime? EndDate { get; private set; }
    public string Responsibilities { get; private set; }

    public WorkExperience(
        string company,
        string role,
        DateTime startDate,
        DateTime? endDate,
        string responsibilities)
    {
        Company = company;
        Role = role;
        StartDate = startDate;
        EndDate = endDate;
        Responsibilities = responsibilities;
    }

    public void Update(
        string role,
        DateTime? endDate,
        string responsibilities)
    {
        Role = role;
        EndDate = endDate;
        Responsibilities = responsibilities;
    }
}
