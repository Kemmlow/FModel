using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using FModel.ViewModels;

namespace FModel.Mac.Views.Settings;

public partial class AesManager : Window
{
    public AesManager()
    {
        InitializeComponent();
        DataContext = new AesManagerViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
