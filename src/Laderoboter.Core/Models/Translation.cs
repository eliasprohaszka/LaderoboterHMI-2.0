namespace Laderoboter.Core.Models;

public class Translation
{
    public int Id { get; set; }
    public required string Key { get; set; }
    public required string Value { get; set; }
    public int LanguageId { get; set; }
    public string? Category { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public virtual Language Language { get; set; } = null!;
}
