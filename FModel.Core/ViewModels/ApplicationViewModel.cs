using FModel.Framework;
using System.Collections.ObjectModel;
namespace FModel.ViewModels;
public class ApplicationViewModel : ViewModel {
    public string Title => "FModel - MacOS Port";
    public FStatus Status { get; set; } = new();
    public ObservableCollection<object> Tabs { get; } = new();
    public CUE4ParseViewModel CUE4Parse { get; } = new();
    public void OnStartup() { Status.Label = "Ready"; }
}
