namespace Laderoboter.UI.Services;

public interface IVirtualKeyboardService
{
    event EventHandler<VirtualKeyboardEventArgs>? KeyboardRequested;
    event EventHandler? KeyboardClosed;

    bool IsVisible { get; }

    void Show(string inputId, string initialValue, string placeholder, string inputType);
    void Hide();
    void Confirm(string value);
    void Cancel();
}

public class VirtualKeyboardEventArgs : EventArgs
{
    public string InputId { get; set; } = "";
    public string InitialValue { get; set; } = "";
    public string Placeholder { get; set; } = "";
    public string InputType { get; set; } = "text";
}
