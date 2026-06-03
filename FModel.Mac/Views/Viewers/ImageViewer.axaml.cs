using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FModel.Mac.Views.Viewers;

public partial class ImageViewer : UserControl
{
    public ImageViewer()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
