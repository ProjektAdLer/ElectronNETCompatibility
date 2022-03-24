using ElectronNET.API;
using ElectronNET.API.Entities;
using System;
using System.Threading.Tasks;

namespace ElectronWrapper
{
    interface IWebContentsWrapper
    {
        int Id { get; }
        Session Session { get; }

        event Action<bool> OnCrashed;
        event Action OnDidFinishLoad;

        Task<PrinterInfo[]> GetPrintersAsync();
        Task<string> GetUrl();
        void InsertCSS(bool isBrowserWindow, string path);
        Task LoadURLAsync(string url);
        Task LoadURLAsync(string url, LoadURLOptions options);
        void OpenDevTools();
        void OpenDevTools(OpenDevToolsOptions openDevToolsOptions);
        Task<bool> PrintAsync(PrintOptions options = null);
        Task<bool> PrintToPDFAsync(string path, PrintToPDFOptions options = null);
    }
}