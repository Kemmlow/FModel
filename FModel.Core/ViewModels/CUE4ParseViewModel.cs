using FModel.Framework;
using FModel.Settings;
using CUE4Parse.FileProvider;
using CUE4Parse.UE4.Versions;
using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;

namespace FModel.ViewModels;

public class CUE4ParseViewModel : ViewModel
{
    public DefaultFileProvider? Provider { get; private set; }
    public ObservableCollection<FileTreeItem> TreeItems { get; } = new();

    public void Initialize(string path, EGame version)
    {
        if (!Directory.Exists(path)) return;

        Provider = new DefaultFileProvider(path, SearchOption.AllDirectories, true, new VersionContainer(version));
        Provider.Initialize();

        PopulateTree();
    }

    private void PopulateTree()
    {
        TreeItems.Clear();
        if (Provider == null) return;

        var rootNode = new FileTreeItem("Game", true);
        var nodes = new Dictionary<string, FileTreeItem> { { "", rootNode } };

        foreach (var file in Provider.Files.Values.OrderBy(x => x.Path))
        {
            var parts = file.Path.Split('/');
            var currentPath = "";

            for (int i = 0; i < parts.Length; i++)
            {
                var part = parts[i];
                var parentPath = currentPath;
                currentPath = string.IsNullOrEmpty(currentPath) ? part : currentPath + "/" + part;
                var isDir = i < parts.Length - 1;

                if (!nodes.ContainsKey(currentPath))
                {
                    var newNode = new FileTreeItem(part, isDir);
                    nodes[parentPath].Children.Add(newNode);
                    nodes[currentPath] = newNode;
                }
            }
        }
        TreeItems.Add(rootNode);
    }
}

public class FileTreeItem : ViewModel
{
    public string Name { get; }
    public bool IsDirectory { get; }
    public ObservableCollection<FileTreeItem> Children { get; } = new();

    public FileTreeItem(string name, bool isDirectory)
    {
        Name = name;
        IsDirectory = isDirectory;
    }
}
