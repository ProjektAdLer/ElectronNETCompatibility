using System;
using System.Linq;

namespace ElectronWrapper;

public class OpenDialogOptions
{
    public OpenDialogOptions()
    {
        _innerOpenDialogOptions = new ElectronNET.API.Entities.OpenDialogOptions();
    }

    internal OpenDialogOptions(ElectronNET.API.Entities.OpenDialogOptions innerOpenDialogOptions)
    {
        _innerOpenDialogOptions = innerOpenDialogOptions;
    }
    
    internal readonly ElectronNET.API.Entities.OpenDialogOptions _innerOpenDialogOptions;

    public string Title
    {
        get => _innerOpenDialogOptions.Title;
        set => _innerOpenDialogOptions.Title = value;
    }

    public string DefaultPath
    {
        get => _innerOpenDialogOptions.DefaultPath;
        set => _innerOpenDialogOptions.DefaultPath = value;
    }

    public FileFilter[] Filters
    {
        get => _innerOpenDialogOptions.Filters.Select(f => new FileFilter(f)).ToArray();
        set => _innerOpenDialogOptions.Filters = value.Select(f => f._innerFileFilter).ToArray();
    }

    public OpenDialogProperty[] Properties
    {
        get => _innerOpenDialogOptions.Properties.Select(MapForward).ToArray();
        set => _innerOpenDialogOptions.Properties = value.Select(MapBackwards).ToArray();
    }

    private OpenDialogProperty MapForward(ElectronNET.API.Entities.OpenDialogProperty prop) => prop switch
    {
        ElectronNET.API.Entities.OpenDialogProperty.openFile => OpenDialogProperty.openFile,
        ElectronNET.API.Entities.OpenDialogProperty.openDirectory => OpenDialogProperty.openDirectory,
        ElectronNET.API.Entities.OpenDialogProperty.multiSelections => OpenDialogProperty.multiSelections,
        ElectronNET.API.Entities.OpenDialogProperty.showHiddenFiles => OpenDialogProperty.showHiddenFiles,
        ElectronNET.API.Entities.OpenDialogProperty.createDirectory => OpenDialogProperty.createDirectory,
        ElectronNET.API.Entities.OpenDialogProperty.promptToCreate => OpenDialogProperty.promptToCreate,
        ElectronNET.API.Entities.OpenDialogProperty.noResolveAliases => OpenDialogProperty.noResolveAliases,
        ElectronNET.API.Entities.OpenDialogProperty.treatPackageAsDirectory => OpenDialogProperty
            .treatPackageAsDirectory,
        _ => throw new ArgumentOutOfRangeException(nameof(prop), prop, null)
    };

    private ElectronNET.API.Entities.OpenDialogProperty MapBackwards(ElectronWrapper.OpenDialogProperty prop) => prop switch
    {
        OpenDialogProperty.openFile => ElectronNET.API.Entities.OpenDialogProperty.openFile,
        OpenDialogProperty.openDirectory => ElectronNET.API.Entities.OpenDialogProperty.openDirectory,
        OpenDialogProperty.multiSelections => ElectronNET.API.Entities.OpenDialogProperty.multiSelections,
        OpenDialogProperty.showHiddenFiles => ElectronNET.API.Entities.OpenDialogProperty.showHiddenFiles,
        OpenDialogProperty.createDirectory => ElectronNET.API.Entities.OpenDialogProperty.createDirectory,
        OpenDialogProperty.promptToCreate => ElectronNET.API.Entities.OpenDialogProperty.promptToCreate,
        OpenDialogProperty.noResolveAliases => ElectronNET.API.Entities.OpenDialogProperty.noResolveAliases,
        OpenDialogProperty.treatPackageAsDirectory => ElectronNET.API.Entities.OpenDialogProperty
            .treatPackageAsDirectory,
        _ => throw new ArgumentOutOfRangeException(nameof(prop), prop, null)
    };
}