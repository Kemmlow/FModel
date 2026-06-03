using FModel.ViewModels;

namespace FModel.Mac.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ApplicationViewModel AppVM => FModel.Services.ApplicationService.ApplicationView as ApplicationViewModel ?? new ApplicationViewModel();
}
