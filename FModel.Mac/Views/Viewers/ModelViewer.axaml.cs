using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FModel.Mac.Views.Viewers;

public partial class ModelViewer : UserControl
{
    public ModelViewer()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
