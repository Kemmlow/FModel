namespace FModel.Interfaces;
public interface IApplicationView {
    void Restart();
    void Exit();
    void CopyToClipboard(string text);
}
