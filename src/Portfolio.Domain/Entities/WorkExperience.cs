namespace Portfolio.Domain.Entities;

/// <summary>
/// Represents a professional experience entry.
/// </summary>
public class WorkExperience : BaseEntity
{
    /// <summary>
    /// Gets the company name.
    /// </summary>
    public string Company { get; private set; }

    /// <summary>
    /// Gets the role or job title.
    /// </summary>
    public string Role { get; private set; }

    /// <summary>
    /// Gets the start date of the work experience.
    /// </summary>
    public DateTime StartDate { get; private set; }

    /// <summary>
    /// Gets the end date of the work experience, if applicable.
    /// </summary>
    public DateTime? EndDate { get; private set; }

    /// <summary>
    /// Gets the responsibilities or description of the work experience.
    /// </summary>
    public string Responsibilities { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkExperience"/> class.
    /// </summary>
    /// <param name="company">The company name.</param>
    /// <param name="role">The role or job title.</param>
    /// <param name="startDate">The start date of the work experience.</param>
    /// <param name="endDate">The end date of the work experience, if applicable.</param>
    /// <param name="responsibilities">The responsibilities or description.</param>
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

    /// <summary>
    /// Updates the role, end date, and responsibilities of the work experience.
    /// </summary>
    /// <param name="role">The new role or job title.</param>
    /// <param name="endDate">The new end date, if applicable.</param>
    /// <param name="responsibilities">The new responsibilities or description.</param>
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
