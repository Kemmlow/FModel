using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FModel.Mac.Views.Settings;

public partial class DirectorySelector : Window
{
    public DirectorySelector()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
