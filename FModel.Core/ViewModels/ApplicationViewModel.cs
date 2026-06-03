using FModel.Framework;
using FModel.Services;
using System.Collections.ObjectModel;

namespace FModel.ViewModels;

public class ApplicationViewModel : ViewModel
{
    public string Title => "FModel - MacOS Port";

    private FStatus _status = new();
    public FStatus Status
    {
        get => _status;
        set => SetProperty(ref _status, value);
    }

    public ObservableCollection<object> Tabs { get; } = new();
    public CUE4ParseViewModel CUE4Parse { get; } = new();

    public void OnStartup()
    {
        Status.Label = "Ready";
    }
}
