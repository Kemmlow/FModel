using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace FModel.Mac.Views;

public partial class About : Window
{
    public About()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void CloseButton_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }
}
