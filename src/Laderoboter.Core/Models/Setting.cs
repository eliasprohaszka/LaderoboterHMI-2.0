namespace Laderoboter.Core.Models;

public class Setting
{
    public int Id { get; set; }
    public required string SettingKey { get; set; }
    public string? SettingValue { get; set; }
    public string ValueType { get; set; } = "string";
    public string? Category { get; set; }
    public string? Description { get; set; }
    public string? DefaultValue { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public bool IsSystemSetting { get; set; }
}
