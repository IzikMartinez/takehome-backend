namespace takehome.Entities
{
    /// <summary>
    /// Simple record for an insurance quote.
    /// </summary>
    public record Quote
    {
        public decimal Price { get; init; }
    }
}