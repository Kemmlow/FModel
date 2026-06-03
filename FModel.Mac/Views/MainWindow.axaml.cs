using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using FModel.Mac.ViewModels;
using FModel.Mac.Services;
using FModel.Services;
using FModel.Mac.Views.Settings;
using System.Threading.Tasks;
using CUE4Parse.UE4.Versions;

namespace FModel.Mac.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ApplicationService.DialogService = new AvaloniaDialogService(this);
        DataContext = new MainWindowViewModel();

        var vm = (MainWindowViewModel)DataContext;
        vm.AppVM.OnStartup();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public async void OnOpenClick(object sender, RoutedEventArgs e)
    {
        var dialog = new OpenFolderDialog { Title = "Select game folder" };
        var result = await dialog.ShowAsync(this);
        if (!string.IsNullOrEmpty(result))
        {
            var vm = (MainWindowViewModel)DataContext;
            vm.AppVM.CUE4Parse.Initialize(result, EGame.GAME_UE4_27);
            vm.AppVM.Status.Label = "Loaded: " + result;
        }
    }

    public void OnSettingsClick(object sender, RoutedEventArgs e) => new SettingsView().ShowDialog(this);
    public void OnAesManagerClick(object sender, RoutedEventArgs e) => new AesManager().ShowDialog(this);
    public void OnAboutClick(object sender, RoutedEventArgs e) => new About().ShowDialog(this);
    public void OnExitClick(object sender, RoutedEventArgs e) => Close();
}
