namespace Laderoboter.Core.Models;

public class RegisterData
{
    public int Address { get; set; }
    public int Value { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}

public class IoSignal
{
    public int Address { get; set; }
    public bool Value { get; set; }
    public IoSignalType Type { get; set; }
}

public enum IoSignalType
{
    DigitalInput,
    DigitalOutput
}
