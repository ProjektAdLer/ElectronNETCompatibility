namespace ElectronWrapper;

public class FileFilter
{
    public FileFilter()
    {
        _innerFileFilter = new ElectronNET.API.Entities.FileFilter();
    }

    internal FileFilter(ElectronNET.API.Entities.FileFilter innerFileFilter)
    {
        _innerFileFilter = innerFileFilter;
    }
    internal ElectronNET.API.Entities.FileFilter _innerFileFilter { get; }

    public string[] Extensions
    {
        get => _innerFileFilter.Extensions;
        set => _innerFileFilter.Extensions = value;
    }

    public string Name
    {
        get => _innerFileFilter.Name;
        set => _innerFileFilter.Name = value;
    }
}