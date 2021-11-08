using System;

namespace takehome.Entities
{
    public record Applicant
    {
        public Guid Id { get; init; }
        public decimal Revenue { get; init; }
        public string State { get; init; }
        public string Business { get; init; }
    }
}