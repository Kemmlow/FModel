namespace FModel.Interfaces;
public interface IDialogService {
    void ShowMessage(string message, string caption);
    bool ShowConfirmation(string message, string caption);
    string? OpenFolderDialog(string title);
}
