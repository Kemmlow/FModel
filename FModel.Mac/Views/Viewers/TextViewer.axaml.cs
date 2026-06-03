using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FModel.Mac.Views.Viewers;

public partial class TextViewer : UserControl
{
    public TextViewer()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
