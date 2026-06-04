using FModel.Framework;
using CUE4Parse.FileProvider;
using CUE4Parse.UE4.Versions;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace FModel.ViewModels;
public class CUE4ParseViewModel : ViewModel {
    public DefaultFileProvider? Provider { get; private set; }
    public ObservableCollection<FileTreeItem> TreeItems { get; } = new();
    public void Initialize(string path, EGame version) {
        if (!Directory.Exists(path)) return;
        Provider = new DefaultFileProvider(path, SearchOption.AllDirectories, true, new VersionContainer(version));
        Provider.Initialize();
        TreeItems.Clear();
        var root = new FileTreeItem("Game", true);
        TreeItems.Add(root);
    }
}
public class FileTreeItem : ViewModel {
    public string Name { get; }
    public bool IsDirectory { get; }
    public ObservableCollection<FileTreeItem> Children { get; } = new();
    public FileTreeItem(string name, bool isDirectory) { Name = name; IsDirectory = isDirectory; }
}
