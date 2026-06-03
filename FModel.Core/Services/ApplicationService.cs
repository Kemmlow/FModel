using FModel.Core.Interfaces;
namespace FModel.Services {
    public sealed class ApplicationService {
        public static IDialogService DialogService { get; set; } = null!;
        public static IApplicationView PlatformView { get; set; } = null!;
        public static object? ApplicationView { get; set; }
    }
}
