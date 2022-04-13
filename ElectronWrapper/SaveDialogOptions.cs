using System.Linq;

namespace ElectronWrapper;

public class SaveDialogOptions
{
    public SaveDialogOptions()
    {
        _innerSaveDialogOptions = new ElectronNET.API.SaveDialogOptions();
    }

    internal SaveDialogOptions(ElectronNET.API.SaveDialogOptions innerSaveDialogOptions)
    {
        _innerSaveDialogOptions = innerSaveDialogOptions;
    }
    
    internal readonly ElectronNET.API.SaveDialogOptions _innerSaveDialogOptions;

    public string Title
    {
        get => _innerSaveDialogOptions.Title;
        set => _innerSaveDialogOptions.Title = value;
    }

    public string DefaultPath
    {
        get => _innerSaveDialogOptions.DefaultPath;
        set => _innerSaveDialogOptions.DefaultPath = value;
    }

    public string ButtonLabel
    {
        get => _innerSaveDialogOptions.ButtonLabel;
        set => _innerSaveDialogOptions.ButtonLabel = value;
    }

    public FileFilter[] Filters
    {
        get => _innerSaveDialogOptions.Filters.Select(f => new FileFilter(f)).ToArray();
        set => _innerSaveDialogOptions.Filters = value.Select(f => f._innerFileFilter).ToArray();
    }
}