namespace Laderoboter.UI.Services;

public class VirtualKeyboardService : IVirtualKeyboardService
{
    public event EventHandler<VirtualKeyboardEventArgs>? KeyboardRequested;
    public event EventHandler? KeyboardClosed;

    public bool IsVisible { get; private set; }

    public void Show(string inputId, string initialValue, string placeholder, string inputType)
    {
        IsVisible = true;
        KeyboardRequested?.Invoke(this, new VirtualKeyboardEventArgs
        {
            InputId = inputId,
            InitialValue = initialValue,
            Placeholder = placeholder,
            InputType = inputType
        });
    }

    public void Hide()
    {
        IsVisible = false;
        KeyboardClosed?.Invoke(this, EventArgs.Empty);
    }

    public void Confirm(string value)
    {
        Hide();
    }

    public void Cancel()
    {
        Hide();
    }
}
