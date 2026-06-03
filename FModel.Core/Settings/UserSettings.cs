using FModel.Framework;
using System.IO;
using System;
using Newtonsoft.Json;

namespace FModel.Settings;

public class UserSettings : ViewModel
{
    public static UserSettings Default { get; set; } = new();

    public static string DataFolder => Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "FModel"
    );

    public static string FilePath => Path.Combine(DataFolder, "Settings.json");

    public string OutputDirectory { get; set; } = Path.Combine(DataFolder, "Output");
    public string GameDirectory { get; set; } = string.Empty;

    public static void Load()
    {
        if (File.Exists(FilePath))
        {
            try { Default = JsonConvert.DeserializeObject<UserSettings>(File.ReadAllText(FilePath)) ?? new(); }
            catch { Default = new(); }
        }
    }

    public static void Save()
    {
        Directory.CreateDirectory(DataFolder);
        File.WriteAllText(FilePath, JsonConvert.SerializeObject(Default, Formatting.Indented));
    }
}
