namespace ElectronWrapper;

public class BrowserWindow
{
    public BrowserWindow()
    {
        
    }

    internal BrowserWindow(ElectronNET.API.BrowserWindow innerBrowserWindow)
    {
        _innerBrowserWindow = innerBrowserWindow;
    }
    
    internal ElectronNET.API.BrowserWindow? _innerBrowserWindow { get; }
    
}