using System;

namespace takehome.Entities
{
    /// <summary>
    /// Applicant is a record containing information sent from the POST endpoint. This data will be used to calculate
    /// an insurance premium
    /// </summary>
    public record Applicant
    {
        public Guid Id { get; init; }
        public decimal Revenue { get; init; }
        public string State { get; init; }
        public string Business { get; init; }
    }
}