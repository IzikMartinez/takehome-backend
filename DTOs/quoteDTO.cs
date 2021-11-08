namespace takehome.DTOs
{
    /// <summary>
    /// This record is a data transfer object. In this case, it renames Price in the Quote entity to Premium.
    /// This is the schema that will be returned by the POST endpoint
    /// </summary>
    public record QuoteDto
    {
        public decimal Premium { get; init; }
    }
}