namespace FModel.Framework;

public enum EStatusKind { Loading, Stopping, Ready }

public class FStatus : ViewModel
{
    private bool _isReady;
    public bool IsReady
    {
        get => _isReady;
        set => SetProperty(ref _isReady, value);
    }

    private EStatusKind _kind;
    public EStatusKind Kind
    {
        get => _kind;
        set
        {
            SetProperty(ref _kind, value);
            IsReady = Kind != EStatusKind.Loading && Kind != EStatusKind.Stopping;
        }
    }

    private string _label = string.Empty;
    public string Label
    {
        get => _label;
        set => SetProperty(ref _label, value);
    }

    public FStatus()
    {
        SetStatus(EStatusKind.Loading);
    }

    public void SetStatus(EStatusKind kind, string label = "")
    {
        Kind = kind;
        UpdateStatusLabel(label);
    }

    public void UpdateStatusLabel(string label, string prefix = null)
    {
        Label = Kind == EStatusKind.Loading ? $"{prefix ?? Kind.ToString()} {label}".Trim() : Kind.ToString();
    }
}
