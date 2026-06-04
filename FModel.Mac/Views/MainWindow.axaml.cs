using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;
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
        var folders = await this.StorageProvider.OpenFolderPickerAsync(new FolderPickerOpenOptions
        {
            Title = "Select game folder",
            AllowMultiple = false
        });

        if (folders != null && folders.Count > 0)
        {
            var result = folders[0].Path.LocalPath;
            var vm = (MainWindowViewModel)DataContext;
            if (vm != null)
            {
                vm.AppVM.CUE4Parse.Initialize(result, EGame.GAME_UE4_27);
                vm.AppVM.Status.Label = "Loaded: " + result;
            }
        }
    }

    public void OnSettingsClick(object sender, RoutedEventArgs e) => new SettingsView().ShowDialog(this);
    public void OnAesManagerClick(object sender, RoutedEventArgs e) => new AesManager().ShowDialog(this);
    public void OnAboutClick(object sender, RoutedEventArgs e) => new About().ShowDialog(this);
    public void OnExitClick(object sender, RoutedEventArgs e) => Close();
}
