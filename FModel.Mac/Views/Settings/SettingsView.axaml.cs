using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FModel.Mac.Views.Settings;

public partial class SettingsView : Window
{
    public SettingsView()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
