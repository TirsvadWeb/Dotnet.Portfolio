namespace Portfolio.Domain.Entities
{
    /// <summary>
    /// Represents an educational experience or qualification.
    /// </summary>
    public class Education : BaseEntity
    {
        /// <summary>
        /// Gets the name of the educational institution.
        /// </summary>
        public string Institution { get; private set; }

        /// <summary>
        /// Gets the degree or qualification obtained.
        /// </summary>
        public string Degree { get; private set; }

        /// <summary>
        /// Gets the start date of the education period.
        /// </summary>
        public DateTime StartDate { get; private set; }

        /// <summary>
        /// Gets the end date of the education period, if applicable.
        /// </summary>
        public DateTime? EndDate { get; private set; }

        /// <summary>
        /// Gets the description or details about the education.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Education"/> class.
        /// </summary>
        /// <param name="institution">The name of the educational institution.</param>
        /// <param name="degree">The degree or qualification obtained.</param>
        /// <param name="startDate">The start date of the education period.</param>
        /// <param name="endDate">The end date of the education period, if applicable.</param>
        /// <param name="description">The description or details about the education.</param>
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

        /// <summary>
        /// Updates the degree, end date, and description of the education.
        /// </summary>
        /// <param name="degree">The new degree or qualification.</param>
        /// <param name="endDate">The new end date of the education period, if applicable.</param>
        /// <param name="description">The new description or details about the education.</param>
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
