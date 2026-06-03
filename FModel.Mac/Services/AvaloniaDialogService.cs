using Avalonia.Controls;
using FModel.Core.Interfaces;
using System.Threading.Tasks;

namespace FModel.Mac.Services;

public class AvaloniaDialogService : IDialogService
{
    private readonly Window _owner;

    public AvaloniaDialogService(Window owner)
    {
        _owner = owner;
    }

    public void ShowMessage(string message, string caption)
    {
        // Simple message box using Avalonia (placeholder)
        System.Console.WriteLine($"[{caption}] {message}");
    }

    public bool ShowConfirmation(string message, string caption)
    {
        return true;
    }

    public string? OpenFolderDialog(string title)
    {
        // Placeholder for real folder picker
        return null;
    }
}
