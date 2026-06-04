using FModel.Framework;
using System.Collections.ObjectModel;

namespace FModel.ViewModels;

public class AesKeyEntry {
    public string Guid { get; set; } = string.Empty;
    public string Key { get; set; } = string.Empty;
}

public class AesManagerViewModel : ViewModel
{
    public ObservableCollection<AesKeyEntry> Keys { get; } = new();
    public string MainKey { get; set; } = string.Empty;
}
