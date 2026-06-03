using FModel.Interfaces;
using FModel.ViewModels;
namespace FModel.Services {
    public sealed class ApplicationService {
        public static IDialogService DialogService { get; set; } = null!;
        public static IApplicationView PlatformView { get; set; } = null!;
        public static ApplicationViewModel ApplicationView { get; } = new();
    }
}
