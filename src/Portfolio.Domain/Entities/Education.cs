// Domain/Entities/Education.cs
namespace Portfolio.Domain.Entities
{
    public class Education : BaseEntity
    {
        public string Institution { get; private set; }
        public string Degree { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime? EndDate { get; private set; }
        public string Description { get; private set; }

        public Education(
            string institution,
            string degree,
            DateTime startDate,
            DateTime? endDate,
            string description)
        {
            Institution = institution;
            Degree = degree;
            StartDate = startDate;
            EndDate = endDate;
            Description = description;
        }

        public void Update(
            string degree,
            DateTime? endDate,
            string description)
        {
            Degree = degree;
            EndDate = endDate;
            Description = description;
        }
    }
}
